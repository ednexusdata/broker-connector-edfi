using System;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using Microsoft.Extensions.Logging;
using OregonNexus.Broker.Connector.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentResourcePayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";

    public override string? Content { get; set; }

    public static async Task<StudentResourcePayloadContent> ExecuteAsync()
    {
        var api = new StudentsApi("NEED CONFIGURATION");
        var response = await api.GetStudentsWithHttpInfoAsync(studentUniqueId: "TEST");
        var httpReponseCode = response.StatusCode;
        var students = response.Data;

        // _logger.LogInformation($"{httpReponseCode.ToString()} {students.ToString()}");

        var dataContent = new StudentResourcePayloadContent()
        {
            Content = JsonSerializer.Serialize(students)
        };
        return dataContent;
        //return new Task<StudentResourcePayloadContent>(() => new StudentResourcePayloadContent());
    }
}