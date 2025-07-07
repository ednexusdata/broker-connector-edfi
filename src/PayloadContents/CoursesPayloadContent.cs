using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class CoursesV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursesV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiCourse).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class CoursesV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursesV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiCourse).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class CoursesV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursesV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiCourse).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class CoursesV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursesV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiCourse).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class CoursesV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.Course",
        ObjectType = typeof(CoursesV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiCourse).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}