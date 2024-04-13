using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentInterventionAssociationsJob))]
[DisplayName("Student Interventions")]
public class StudentInterventionAssociationsPayloadContent : PayloadContentType
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
