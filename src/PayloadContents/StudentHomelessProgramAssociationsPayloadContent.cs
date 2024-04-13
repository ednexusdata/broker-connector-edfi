using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentHomelessProgramAssociationsJob))]
[DisplayName("Student Homeless Programs")]
public class StudentHomelessProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentHomelessProgramAssociations",
        ObjectType = typeof(StudentHomelessProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentHomelessProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
