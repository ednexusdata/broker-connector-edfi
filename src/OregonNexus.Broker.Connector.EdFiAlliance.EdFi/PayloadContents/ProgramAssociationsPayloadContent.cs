using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;


[DisplayName("Programs")]
public class ProgramAssociationsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string Content { 
        get {
            return JsonSerializer.Serialize(JsonContent);
        }
    }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}

    // private async Task<ProgramAssociationsPayloadContent> ExecuteAsync()
    // {
    //     var api = new StudentProgramAssociationsApi(BasePath);
    //     var response = await api.GetStudentProgramAssociationsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
    //     var programAssociations = response.Data;

    //     var dataContent = new ProgramAssociationsPayloadContent()
    //     {
    //         Content = JsonSerializer.Serialize(programAssociations)
    //     };
    //     return dataContent;
    // }
}
