using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentGradebookEntriesJob))]
[DisplayName("Student Gradebook Entries")]
public class StudentGradebookEntriesPayloadContent : PayloadContentType
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
