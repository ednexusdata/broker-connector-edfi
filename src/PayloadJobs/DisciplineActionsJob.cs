using EdNexusData.Broker.Core.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Discipline Actions")]
public class DisciplineActionsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsPayloadContent()
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
