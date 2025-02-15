using System.Net;
using System.Runtime.Serialization;
using System.Security.Authentication;
using EdFi.OdsApi.Sdk.Client;
using Config = EdFi.OdsApi.Sdk.Client.Configuration;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi;

public class TokenRetriever
{
    private string oauthUrl;
    private string clientKey;
    private string clientSecret;

    public TokenRetriever(string oauthUrl, string clientKey, string clientSecret)
    {
        this.oauthUrl = oauthUrl;
        this.clientKey = clientKey;
        this.clientSecret = clientSecret;
    }

    public async Task<string?> ObtainNewBearerToken()
    {
        var oauthClient = new ApiClient(oauthUrl);
        return await GetBearerToken(oauthClient);
    }

    private async Task<string?> GetBearerToken(ApiClient oauthClient)
    {
        var configuration = new Config() { BasePath = oauthUrl };
        var bearerTokenRequestOptions = new RequestOptions() { Operation = String.Empty };
        bearerTokenRequestOptions.FormParameters.Add("client_id", clientKey);
        bearerTokenRequestOptions.FormParameters.Add("client_secret", clientSecret);
        bearerTokenRequestOptions.FormParameters.Add("grant_type", "client_credentials");

        var bearerTokenResponse = await oauthClient.PostAsync<BearerTokenResponse>("oauth/token", bearerTokenRequestOptions, configuration);

        if (bearerTokenResponse is null)
        {
            return null;
        }
            
        if (bearerTokenResponse.StatusCode != HttpStatusCode.OK)
        {
            throw new AuthenticationException("Unable to retrieve an access token. Error message: " +
                                                bearerTokenResponse.Data.Error);
        }

        if (bearerTokenResponse.Data.Error != null || bearerTokenResponse.Data.TokenType != "bearer")
        {
            throw new AuthenticationException(
                "Unable to retrieve an access token. Please verify that your application secret is correct.");
        }

        return bearerTokenResponse.Data.AccessToken;
    }
}

[DataContract]
internal class BearerTokenResponse
{
    [DataMember(Name = "access_token", EmitDefaultValue = false)]
    public string? AccessToken { get; set; }

    [DataMember(Name = "expires_in", EmitDefaultValue = false)]
    public string? ExpiresIn { get; set; }

    [DataMember(Name = "token_type", EmitDefaultValue = false)]
    public string? TokenType { get; set; }

    [DataMember(Name = "error", EmitDefaultValue = false)]
    public string? Error { get; set; }
}