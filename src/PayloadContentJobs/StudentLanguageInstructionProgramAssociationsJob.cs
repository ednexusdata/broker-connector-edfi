using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentLanguageInstructionProgramAssociationsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentLanguageInstructionProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentLanguageInstructionProgramAssociationsApi(configuration);
        var response = await api.GetStudentLanguageInstructionProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentLanguageInstructionProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
