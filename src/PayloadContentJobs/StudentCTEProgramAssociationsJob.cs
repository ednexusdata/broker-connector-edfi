using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentCTEProgramAssociationsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCTEProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentCTEProgramAssociationsApi(configuration);
        var response = await api.GetStudentCTEProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCTEProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
