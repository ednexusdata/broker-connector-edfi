using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Programs")]
public class StudentProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentProgramAssociationsApi(config);
        var response = await api.GetStudentProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count > 0)
        {
            return dataContent;
        }

        return null;
    }
}
