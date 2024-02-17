using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using OregonNexus.Broker.Connector.Attributes;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using OregonNexus.Broker.Connector.PayloadContentTypes;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(CourseTranscriptsJob))]
[DisplayName("Course Transcripts")]
public class CourseTranscriptsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = nameof(EdFiCourseTranscript),
        SchemaVersion = "3"
    };
}
