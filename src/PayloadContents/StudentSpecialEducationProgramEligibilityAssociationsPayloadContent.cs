using EdNexusData.Broker.Core.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentSpecialEducationProgramEligibilityAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentSpecialEducationProgramEligibility",
        ObjectType = typeof(StudentSpecialEducationProgramEligibilityAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentSpecialEducationProgramEligibilityAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };
}
