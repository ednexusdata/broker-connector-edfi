using EdNexusData.Broker.Core.Configuration;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Configuration;
using EdFiOdsSdk = EdFi.OdsApi.Sdk.Client;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

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

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();

        _ = retrievedToken ?? throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}/data/v3"
        };

        return configuration;
    }
}
