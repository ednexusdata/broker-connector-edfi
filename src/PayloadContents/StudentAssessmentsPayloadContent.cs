using EdNexusData.Broker.Core.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentAssessmentsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentAssessment).FullName!,
        SchemaVersion = "4.0.0"
    };
}
