using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Assessments")]
public class StudentAssessmentsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentAssessmentsApi(configuration);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
