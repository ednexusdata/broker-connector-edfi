using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Discipline Actions")]
public class DisciplineActionsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new DisciplineActionsApi(configuration);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
