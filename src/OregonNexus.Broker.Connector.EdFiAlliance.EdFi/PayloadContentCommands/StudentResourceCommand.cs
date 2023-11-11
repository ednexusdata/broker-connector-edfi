using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContents;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContentCommands;
public class StudentResourceCommand : PayloadContent<StudentResourcePayloadContent>
{
    private readonly string _basePath;
    private readonly string _studentUniqueId;
    public StudentResourceCommand(
        string basePath,
        string studentUniqueId)
    {
        _basePath = basePath;
        _studentUniqueId = studentUniqueId;
    }
    public async override Task<StudentResourcePayloadContent> ExecuteAsync()
    {
        var payloadContent = new StudentResourcePayloadContent()
        {
            BasePath = _basePath,
            StudentUniqueId = _studentUniqueId
        };
        await payloadContent.ExecuteAsync();
        return payloadContent;
    }
}
