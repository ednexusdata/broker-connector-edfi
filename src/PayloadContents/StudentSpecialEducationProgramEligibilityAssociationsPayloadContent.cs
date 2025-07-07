using EdNexusData.Broker.Common.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentSpecialEducationProgramEligibilityAssociationsV71PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentSpecialEducationProgramEligibility",
        ObjectType = typeof(StudentSpecialEducationProgramEligibilityAssociationsV71PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v71.Models.All.EdFiStudentSpecialEducationProgramEligibilityAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V71
    };
}

public class StudentSpecialEducationProgramEligibilityAssociationsV72PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentSpecialEducationProgramEligibility",
        ObjectType = typeof(StudentSpecialEducationProgramEligibilityAssociationsV72PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v72.Models.All.EdFiStudentSpecialEducationProgramEligibilityAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V72
    };
}

public class StudentSpecialEducationProgramEligibilityAssociationsV73PayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentSpecialEducationProgramEligibility",
        ObjectType = typeof(StudentSpecialEducationProgramEligibilityAssociationsV73PayloadContent).FullName!,
        ContentObjectType = typeof(EdFiOdsSdk.v73.Models.All.EdFiStudentSpecialEducationProgramEligibilityAssociation).FullName!,
        SchemaVersion = EdFiOdsSdk.Constants.EDFI_ODSAPI_V73
    };
}