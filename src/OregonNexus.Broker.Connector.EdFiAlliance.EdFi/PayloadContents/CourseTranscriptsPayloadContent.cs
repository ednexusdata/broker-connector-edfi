using System.ComponentModel;
using System.Text.Json;
using OregonNexus.Broker.Connector.Attributes;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(CourseTranscriptResourceJob))]
[DisplayName("Course Transcripts")]
public class CourseTranscriptsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "application/json";

    public override string Content { 
        get {
            return JsonSerializer.Serialize(JsonContent);
        }
    }
}
