using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentGradebookEntriesJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentGradebookEntriesJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentGradebookEntriesApi(configuration);
        var response = await api.GetStudentGradebookEntriesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentGradebookEntriesPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
