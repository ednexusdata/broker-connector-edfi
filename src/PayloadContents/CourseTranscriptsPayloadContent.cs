using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class CourseTranscriptsV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiCourseTranscript).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class CourseTranscriptsV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiCourseTranscript).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class CourseTranscriptsV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiCourseTranscript).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class CourseTranscriptsV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiCourseTranscript).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class CourseTranscriptsV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.CourseTranscript",
        ObjectType = typeof(CourseTranscriptsV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiCourseTranscript).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}