using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Discipline Actions")]
public class DisciplineActionsPayloadContent : PayloadContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";

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
