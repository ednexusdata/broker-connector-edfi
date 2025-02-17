using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Interventions")]
public class StudentInterventionAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentInterventionAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentInterventionAssociationsApi(config);
        var response = await api.GetStudentInterventionAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentInterventionAssociationsPayloadContent()
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
