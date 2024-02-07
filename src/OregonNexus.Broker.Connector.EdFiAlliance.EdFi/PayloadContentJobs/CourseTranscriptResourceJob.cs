using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class CourseTranscriptResourceJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public CourseTranscriptResourceJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId, Guid educationOrganizationId)
    {
        var configuration = await _tokenResolver.Resolve(educationOrganizationId);
        
        var api = new CourseTranscriptsApi(configuration);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        var courseTranscripts = response.Data;

        var dataContent = new CourseTranscriptsPayloadContent()
        {
            JsonContent = JsonSerializer.SerializeToDocument(courseTranscripts)
        };

        return dataContent;
    }
}
