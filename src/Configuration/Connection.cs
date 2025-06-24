using System.ComponentModel.DataAnnotations;
using EdNexusData.Broker.Common.Configuration;
using EdNexusData.Broker.Common.Lookup;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.ConfigurationLookups;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Configuration;

[DisplayName("Connection")]
public class Connection : IConfiguration
{
    [Lookup(typeof(EdFiVersionConfigurationLookup))]
    [DisplayName("Version")]
    [Description("The version of the Ed-Fi instance.")]
    public string EdFiVersion { get; set; } = default!;

    [DataType(DataType.Url)]
    [DisplayName("API OAuth URL")]
    [Description("The URL of the OAuth endpoint of the Ed-Fi API instance to connect to.")]
    public string EdFiApiOAuthUrl { get; set; } = default!;

    [DataType(DataType.Url)]
    [DisplayName("API URL")]
    [Description("The URL of the Ed-Fi API instance to connect to.")]
    public string EdFiApiUrl { get; set; } = default!;

    [DataType(DataType.Text)]
    [Description("The key to connect to the Ed-Fi API instance specified in Ed-Fi API URL.")]
    public string Key { get; set; } = default!;

    [DataType(DataType.Password)]
    [Description("The secret to connect to the Ed-Fi API instance specified in Ed-Fi API URL.")]
    public string Secret { get; set; } = default!;
}