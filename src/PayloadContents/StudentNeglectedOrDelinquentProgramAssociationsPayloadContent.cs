using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentNeglectedOrDelinquentProgramAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
