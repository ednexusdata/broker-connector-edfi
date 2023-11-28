using System.Text.Json;
using EdFi.OdsApi.Sdk.Api.Resources;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
public class StudentAssessmentsPayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";
    public override string? Content { get; set; }
    public string BasePath {get;set;}
    public string StudentUniqueId {get;set;}
    private async Task<StudentAssessmentsPayloadContent> ExecuteAsync()
    {
        var api = new StudentAssessmentsApi(BasePath);
        var response = await api.GetStudentAssessmentsAsyncWithHttpInfo(studentUniqueId: StudentUniqueId);
        var assessments = response.Data;

        var dataContent = new StudentAssessmentsPayloadContent()
        {
            Content = JsonSerializer.Serialize(assessments)
        };
        return dataContent;
    }
}