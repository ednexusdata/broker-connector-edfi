using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Interventions")]
public class StudentInterventionAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentInterventionAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentInterventionAssociationsApi(configuration);
        var response = await api.GetStudentInterventionAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentInterventionAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
