using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Cohorts")]
public class StudentCohortAssocationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCohortAssocationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentCohortAssociationsApi(config);
        var response = await api.GetStudentCohortAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCohortAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
