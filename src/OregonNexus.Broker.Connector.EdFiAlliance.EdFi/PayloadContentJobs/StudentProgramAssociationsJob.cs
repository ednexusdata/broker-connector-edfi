using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentProgramAssociationsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentProgramAssociationsApi(configuration);
        var response = await api.GetStudentProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramAssociationsPayloadContent()
        {
            JsonContent = JsonSerializer.SerializeToDocument(response.Data)
        };

        return dataContent;
    }
}
