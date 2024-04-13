using System.ComponentModel;
using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector.PayloadContentTypes;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentCompetencyObjectivesJob))]
[DisplayName("Student Competency Objectives")]
public class StudentCompetencyObjectivesPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentCompetencyObjectives",
        ObjectType = typeof(StudentCompetencyObjectivesPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentCompetencyObjective).FullName!,
        SchemaVersion = "4.0.0"
    };

}
