using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class CoursePayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursePayloadContent).FullName!,
        ContentObjectType = typeof(EdFiCourse).FullName!,
        SchemaVersion = "4.0.0"
    };
}
