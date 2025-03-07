using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentGradebookEntriesPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentGradebookEntries",
        ObjectType = typeof(StudentGradebookEntriesPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentGradebookEntry).FullName!,
        SchemaVersion = "4.0.0"
    };

}
