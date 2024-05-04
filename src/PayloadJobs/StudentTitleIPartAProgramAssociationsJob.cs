using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Title I Part A Programs")]
public class StudentTitleIPartAProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentTitleIPartAProgramAssociationsApi(configuration);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
