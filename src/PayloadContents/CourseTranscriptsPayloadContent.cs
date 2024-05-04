using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class CourseTranscriptsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiCourseTranscript).FullName!,
        SchemaVersion = "4.0.0"
    };
}
