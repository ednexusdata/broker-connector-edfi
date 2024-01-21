using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Course Transcripts")]
public class CourseTranscriptsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string StudentUniqueId {get;set;}
    public string BasePath {get;set;}
    private async Task<CourseTranscriptsPayloadContent> ExecuteAsync()
    {
        var api = new CourseTranscriptsApi(BasePath);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
        var courseTranscripts = response.Data;

        var dataContent = new CourseTranscriptsPayloadContent()
        {
            Content = JsonSerializer.Serialize(courseTranscripts)
        };
        return dataContent;
    }
}
