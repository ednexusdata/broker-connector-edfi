using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentMigrantEducationProgramAssociationsJob))]
[DisplayName("Student Migrant Education Programs")]
public class StudentMigrantEducationProgramAssociationsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentMigrantEducationProgramAssociations",
        ObjectType = typeof(StudentMigrantEducationProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentMigrantEducationProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };

}
