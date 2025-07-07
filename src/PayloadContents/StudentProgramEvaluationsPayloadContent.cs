using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentProgramEvaluations71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentProgramEvaluations",
        ObjectType = typeof(StudentProgramEvaluations71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudentProgramEvaluation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentProgramEvaluations72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentProgramEvaluations",
        ObjectType = typeof(StudentProgramEvaluations72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudentProgramEvaluation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentProgramEvaluations73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentProgramEvaluations",
        ObjectType = typeof(StudentProgramEvaluations73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudentProgramEvaluation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}