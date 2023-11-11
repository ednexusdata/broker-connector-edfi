using System.Text.Json;
using EdFi.OdsApi.Sdk.Api.Resources;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
public class ProgramAssociationsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}

    private async Task<ProgramAssociationsPayloadContent> ExecuteAsync()
    {
        var api = new StudentProgramAssociationsApi(BasePath);
        var response = await api.GetStudentProgramAssociationsAsyncWithHttpInfo(studentUniqueId: StudentUniqueId);
        var programAssociations = response.Data;

        var dataContent = new ProgramAssociationsPayloadContent()
        {
            Content = JsonSerializer.Serialize(programAssociations)
        };
        return dataContent;
    }
}
