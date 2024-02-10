using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Configuration;
using OregonNexus.Broker.Connector.Resolvers;
using EdFiOdsSdk = EdFi.OdsApi.Sdk.Client;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class OAuthTokenResolver
{
    private readonly IConfigurationResolver _configurationResolver;

    public OAuthTokenResolver(IConfigurationResolver configurationResolver)
    {
        _configurationResolver = configurationResolver;
    }

    public async Task<EdFiOdsSdk.Configuration> Resolve()
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

        return configuration;
    }
}
