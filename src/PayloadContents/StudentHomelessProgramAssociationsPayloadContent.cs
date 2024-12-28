using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentHomelessProgramAssociationsPayloadContent : DataPayloadContent
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
