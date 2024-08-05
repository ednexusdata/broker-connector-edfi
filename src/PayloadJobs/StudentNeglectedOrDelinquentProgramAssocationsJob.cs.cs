using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Neglected or Delinquent Programs")]
public class StudentNeglectedOrDelinquentProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentNeglectedOrDelinquentProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentNeglectedOrDelinquentProgramAssociationsApi(config);
        var response = await api.GetStudentNeglectedOrDelinquentProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentNeglectedOrDelinquentProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}
