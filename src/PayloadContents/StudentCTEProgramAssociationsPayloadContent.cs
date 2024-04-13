using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentCTEProgramAssociationsJob))]
[DisplayName("Student CTE Programs")]
public class StudentCTEProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentCTEProgramAssociations",
        ObjectType = typeof(StudentCTEProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentCTEProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
