using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentCTEProgramAssociationsPayloadContent : DataPayloadContent
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
