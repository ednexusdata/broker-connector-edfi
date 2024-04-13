using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentCohortAssocationsJob))]
[DisplayName("Student Cohorts")]
public class StudentCohortAssociationsPayloadContent : PayloadContentType
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
