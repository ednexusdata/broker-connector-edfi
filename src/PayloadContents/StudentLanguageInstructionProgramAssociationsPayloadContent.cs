using EdNexusData.Broker.Core.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentLanguageInstructionProgramAssociationsPayloadContent : DataPayloadContent
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
