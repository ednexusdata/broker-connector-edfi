using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentProgramAssociationsJob))]
[DisplayName("Student Programs")]
public class StudentProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentProgramAssociations",
        ObjectType = typeof(StudentProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentProgramAssociation).FullName!,
        SchemaVersion = "3"
    };
}
