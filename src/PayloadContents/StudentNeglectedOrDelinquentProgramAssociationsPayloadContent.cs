using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentNeglectedOrDelinquentProgramAssociationsJob))]
[DisplayName("Student Neglected or Delinquent Programs")]
public class StudentNeglectedOrDelinquentProgramAssociationsPayloadContent : PayloadContentType
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
