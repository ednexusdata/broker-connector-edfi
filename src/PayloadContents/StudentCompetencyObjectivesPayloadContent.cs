using EdNexusData.Broker.Core.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentCompetencyObjectivesPayloadContent : DataPayloadContent
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
