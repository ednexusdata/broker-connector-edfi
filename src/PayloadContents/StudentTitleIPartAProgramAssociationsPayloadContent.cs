using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentTitleIPartAProgramAssociationsV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class StudentTitleIPartAProgramAssociationsV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class StudentTitleIPartAProgramAssociationsV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentTitleIPartAProgramAssociationsV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentTitleIPartAProgramAssociationsV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}

