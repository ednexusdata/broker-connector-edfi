using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContents;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContentCommands;

public class StudentResourceCommand : PayloadContent<StudentResourcePayloadContent>
{
    public async override Task<StudentResourcePayloadContent> ExecuteAsync()
    {
        var api = new StudentsApi("NEED CONFIGURATION");
        var response = await api.GetStudentsWithHttpInfoAsync(studentUniqueId: "TEST");
        // var httpReponseCode = response.StatusCode;
        // var students = response.Data;

        // _logger.LogInformation($"{httpReponseCode.ToString()} {students.ToString()}");

        // var dataContent = new StudentResourcePayloadContent()
        // {
        //     Content = JsonSerializer.Serialize(students)
        // };
        return new StudentResourcePayloadContent();
        //return new Task<StudentResourcePayloadContent>(() => new StudentResourcePayloadContent());
    }
}