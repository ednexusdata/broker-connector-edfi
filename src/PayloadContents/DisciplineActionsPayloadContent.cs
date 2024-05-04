using EdFi.OdsApi.Sdk.Models.All;
using EdNexusData.Broker.Connector.Attributes;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Connector;
using EdNexusData.Broker.Domain;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class DisciplineActionsPayloadContent : DataPayloadContent
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.DisciplineAction",
        ObjectType = typeof(DisciplineActionsPayloadContent).FullName!,
        ContentObjectType = typeof(EdFiDisciplineAction).FullName!,
        SchemaVersion = "4.0.0"
    };

}
