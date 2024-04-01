using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class DisciplineActionsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
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
