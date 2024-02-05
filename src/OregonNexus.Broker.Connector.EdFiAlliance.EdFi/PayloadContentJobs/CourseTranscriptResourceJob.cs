using System.Reflection;
using System.Text.Json;
using EdFi.OdsApi.Sdk.Apis.All;
using Microsoft.Extensions.DependencyInjection;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Configuration;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContents;
using OregonNexus.Broker.Connector.Resolvers;
using EdFiOdsSdk = EdFi.OdsApi.Sdk.Client;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class CourseTranscriptResourceJob : IPayloadContentJob
{
    private readonly IConfigurationResolver _configurationResolver;

    public CourseTranscriptResourceJob(IConfigurationResolver configurationResolver)
    {
        _configurationResolver = configurationResolver;
    }

    public async Task<CourseTranscriptsPayloadContent> ExecuteAsync<CourseTranscriptsPayloadContent>(string studentUniqueId)
    {
        var connection = await _configurationResolver.FetchConnectorSettingsAsync<Connection>();
        
        // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
        var tokenRetriever = new TokenRetriever(connection.EdFiApiUrl, connection.Key, connection.Secret);

        // Plug Oauth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.Configuration()
        {
            AccessToken = await tokenRetriever.ObtainNewBearerToken(),
            BasePath = $"{connection.EdFiApiUrl}/data/v3"
        };
        
        var api = new CourseTranscriptsApi(configuration);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        var courseTranscripts = response.Data;

        Assembly assem = typeof(CourseTranscriptsPayloadContent).Assembly;
        CourseTranscriptsPayloadContent dataContent = (CourseTranscriptsPayloadContent)assem.CreateInstance(nameof(CourseTranscriptsPayloadContent))!;
        dataContent.Content = JsonSerializer.Serialize(courseTranscripts);

        return dataContent;
    }
}
