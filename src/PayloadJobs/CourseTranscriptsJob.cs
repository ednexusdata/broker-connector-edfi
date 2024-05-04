using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Course Transcripts")]
public class CourseTranscriptsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public CourseTranscriptsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
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
