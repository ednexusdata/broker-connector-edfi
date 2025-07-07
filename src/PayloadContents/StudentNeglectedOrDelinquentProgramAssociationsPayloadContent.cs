using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentNeglectedOrDelinquentProgramAssociationsV54PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsV54PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v54.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V54
    };
}

public class StudentNeglectedOrDelinquentProgramAssociationsV62PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsV62PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v62.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V62
    };
}

public class StudentNeglectedOrDelinquentProgramAssociationsV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentNeglectedOrDelinquentProgramAssociationsV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentNeglectedOrDelinquentProgramAssociationsV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentNeglectedOrDelinquentProgramAssociations",
        ObjectType = typeof(StudentNeglectedOrDelinquentProgramAssociationsV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudentNeglectedOrDelinquentProgramAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}