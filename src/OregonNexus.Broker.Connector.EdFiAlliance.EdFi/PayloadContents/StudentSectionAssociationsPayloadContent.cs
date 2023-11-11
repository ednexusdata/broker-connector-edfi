using System.Text.Json;
using EdFi.OdsApi.Sdk.Api.Resources;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
public class StudentSectionAssociationsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}
    private async Task<StudentSectionAssociationsPayloadContent> ExecuteAsync()
    {
        var api = new StudentSectionAssociationsApi(BasePath);
        var response = await api.GetStudentSectionAssociationsAsyncWithHttpInfo(studentUniqueId: StudentUniqueId);
        var studentSectionAssociations = response.Data;

        var dataContent = new StudentSectionAssociationsPayloadContent()
        {
            Content = JsonSerializer.Serialize(studentSectionAssociations)
        };
        return dataContent;
    }
}
