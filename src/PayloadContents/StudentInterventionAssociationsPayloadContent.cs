using EdNexusData.Broker.Core.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentInterventionAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentInterventionAssociations",
        ObjectType = typeof(StudentInterventionAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentInterventionAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
