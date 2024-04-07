using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class CourseTranscriptsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public CourseTranscriptsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new CourseTranscriptsApi(configuration);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new CourseTranscriptsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
