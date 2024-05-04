using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Gradebook Entries")]
public class StudentGradebookEntriesJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentGradebookEntriesJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentGradebookEntriesApi(configuration);
        var response = await api.GetStudentGradebookEntriesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentGradebookEntriesPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
