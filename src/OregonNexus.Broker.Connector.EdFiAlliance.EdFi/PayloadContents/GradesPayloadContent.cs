using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Grades")]
public class GradesPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}

    public override string Content { 
        get {
            return JsonSerializer.Serialize(JsonContent);
        }
    }

    // private async Task<GradesPayloadContent> ExecuteAsync()
    // {
    //     var api = new GradesApi(BasePath);
    //     var response = await api.GetGradesWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
    //     var grades = response.Data;

    //     var dataContent = new GradesPayloadContent()
    //     {
    //         Content = JsonSerializer.Serialize(grades)
    //     };
    //     return dataContent;
    // }
}
