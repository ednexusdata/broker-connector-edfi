using EdNexusData.Broker.Common.Configuration;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Configuration;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class OAuthTokenResolver
{
    private readonly IConfigurationResolver configurationResolver;

    public OAuthTokenResolver(IConfigurationResolver configurationResolver)
    {
        this.configurationResolver = configurationResolver;
    }

    public async Task<object> Resolve()
    {
        var connection = await configurationResolver.FetchConnectorSettingsAsync<Connection>();
        _ = connection ?? throw new ArgumentNullException(nameof(connection), "Connection settings cannot be null.");

        switch (connection.EdFiVersion)
        {
            case EdFiOdsSdk.Constants.EDFI_ODSAPI_SDK_V54:
                return await ResolveV54(connection);
            case EdFiOdsSdk.Constants.EDFI_ODSAPI_SDK_V62:
                return await ResolveV62(connection);
            case EdFiOdsSdk.Constants.EDFI_ODSAPI_SDK_V71:
                return await ResolveV71(connection);
            case EdFiOdsSdk.Constants.EDFI_ODSAPI_SDK_V72:
                return await ResolveV72(connection);
            default:
                return await ResolveV73(connection);
        }
    }

    private async Task<EdFiOdsSdk.v54.Client.Configuration> ResolveV54(Connection connection)
    {
        var tokenRetriever = new TokenRetriever(connection.EdFiApiOAuthUrl, connection.Key, connection.Secret);

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ??
            throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiOAuthUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.v54.Client.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}"
        };

        return configuration;
    }

    private async Task<EdFiOdsSdk.v62.Client.Configuration> ResolveV62(Connection connection)
    {
        var tokenRetriever = new TokenRetriever(connection.EdFiApiOAuthUrl, connection.Key, connection.Secret);

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ??
            throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiOAuthUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.v62.Client.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}"
        };

        return configuration;
    }

    private async Task<EdFiOdsSdk.v71.Client.Configuration> ResolveV71(Connection connection)
    {
        var tokenRetriever = new TokenRetriever(connection.EdFiApiOAuthUrl, connection.Key, connection.Secret);

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ??
            throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiOAuthUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.v71.Client.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}"
        };

        return configuration;
    }

    private async Task<EdFiOdsSdk.v72.Client.Configuration> ResolveV72(Connection connection)
    {
        var tokenRetriever = new TokenRetriever(connection.EdFiApiOAuthUrl, connection.Key, connection.Secret);

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ??
            throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiOAuthUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.v72.Client.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}"
        };

        return configuration;
    }

    private async Task<EdFiOdsSdk.v73.Client.Configuration> ResolveV73(Connection connection)
    {
        var tokenRetriever = new TokenRetriever(connection.EdFiApiOAuthUrl, connection.Key, connection.Secret);

        // Retrieve token
        var retrievedToken = await tokenRetriever.ObtainNewBearerToken();
        _ = retrievedToken ??
            throw new ArgumentNullException($"Unable to retrieve token for {connection.EdFiApiOAuthUrl} / {nameof(retrievedToken)}");

        // Plug OAuth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.v73.Client.Configuration()
        {
            AccessToken = retrievedToken,
            BasePath = $"{connection.EdFiApiUrl}"
        };

        return configuration;
    }
    
}
