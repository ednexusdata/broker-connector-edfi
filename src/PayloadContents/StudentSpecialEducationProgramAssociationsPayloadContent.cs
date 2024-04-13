using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentSpecialEducationProgramAssociationsJob))]
[DisplayName("Student Special Education Programs")]
public class StudentSpecialEducationProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentSpecialEducationProgram",
        ObjectType = typeof(StudentSpecialEducationProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentSpecialEducationProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };
}
