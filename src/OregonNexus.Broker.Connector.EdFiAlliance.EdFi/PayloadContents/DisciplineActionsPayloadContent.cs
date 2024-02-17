using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFi.OdsApi.Sdk.Models.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;
using OregonNexus.Broker.Domain;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Discipline Actions")]
public class DisciplineActionsPayloadContent : PayloadContentType
{
    public override PayloadContentSchema Schema => new PayloadContentSchema()
    {
        Owner = "EdFi",
        Schema = "EdFi.Resources.DisciplineAction",
        ObjectType = nameof(EdFiDisciplineAction),
        SchemaVersion = "3"
    };

    // private async Task<DisciplineActionsPayloadContent> ExecuteAsync()
    // {
    //     var api = new DisciplineActionsApi(BasePath);
    //     var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
    //     var disciplineActions = response.Data;

    //     var dataContent = new DisciplineActionsPayloadContent()
    //     {
    //         Content = JsonSerializer.Serialize(disciplineActions)
    //     };
    //     return dataContent;
    // }

}
