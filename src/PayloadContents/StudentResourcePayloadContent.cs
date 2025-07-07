using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentResourceV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentResource",
        ObjectType = typeof(StudentResourceV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiStudent).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class StudentResourceV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentResource",
        ObjectType = typeof(StudentResourceV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiStudent).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class StudentResourceV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentResource",
        ObjectType = typeof(StudentResourceV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudent).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentResourceV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentResource",
        ObjectType = typeof(StudentResourceV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudent).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentResourceV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentResource",
        ObjectType = typeof(StudentResourceV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudent).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}