using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentLanguageInstructionProgramAssociationsJob))]
[DisplayName("Student Language Instruction Programs")]
public class StudentLanguageInstructionProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentLanguageInstructionProgramAssociations",
        ObjectType = typeof(StudentLanguageInstructionProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentLanguageInstructionProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
