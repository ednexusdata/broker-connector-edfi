using System.ComponentModel;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[DisplayName("Assessments")]
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
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
        var assessments = response.Data;

        var dataContent = new StudentAssessmentsPayloadContent()
        {
            Content = JsonSerializer.Serialize(assessments)
        };
        return dataContent;
    }
}
