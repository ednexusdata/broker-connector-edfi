using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentTitleIPartAProgramAssociationsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.StudentTitleIPartAProgram",
        ObjectType = typeof(StudentTitleIPartAProgramAssociationsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiStudentTitleIPartAProgramAssociation).FullName!,
        SchemaVersion = "4.0.0"
    };
}
