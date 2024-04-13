using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentCompetencyObjectivesJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentCompetencyObjectivesApi(configuration);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
