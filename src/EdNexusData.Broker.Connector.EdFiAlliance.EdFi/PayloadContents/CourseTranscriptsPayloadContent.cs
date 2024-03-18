using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(CourseTranscriptsJob))]
[DisplayName("Course Transcripts")]
public class CourseTranscriptsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiCourseTranscript).FullName!,
        SchemaVersion = "3"
    };
}
