using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentAssessmentsV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiStudentAssessment).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class StudentAssessmentsV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiStudentAssessment).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class StudentAssessmentsV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudentAssessment).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentAssessmentsV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudentAssessment).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentAssessmentsV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentAssessment",
        ObjectType = typeof(StudentAssessmentsV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudentAssessment).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}