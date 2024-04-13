using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentMigrantEducationProgramAssociationsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentMigrantEducationProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentMigrantEducationProgramAssociationsApi(configuration);
        var response = await api.GetStudentMigrantEducationProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentMigrantEducationProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
