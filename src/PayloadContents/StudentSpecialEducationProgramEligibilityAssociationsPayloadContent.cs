using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentSpecialEducationProgramEligibilityAssociationsJob))]
[DisplayName("Student Special Education Programs Eligibility")]
public class StudentSpecialEducationProgramEligibilityAssociationsPayloadContent : PayloadContentType
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
