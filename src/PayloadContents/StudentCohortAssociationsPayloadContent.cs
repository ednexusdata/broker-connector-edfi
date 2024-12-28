using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentCohortAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentCohortAssociations",
        ObjectType = typeof(StudentCohortAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentCohortAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
