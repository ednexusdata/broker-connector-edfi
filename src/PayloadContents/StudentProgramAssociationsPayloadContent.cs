using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentProgramAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentProgramAssociations",
        ObjectType = typeof(StudentProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };
}
