using System.ComponentModel.DataAnnotations;
using EdNexusData.Broker.Common.Configuration;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Configuration;

[DisplayName("Connection")]
public class Connection : IConfiguration
{
    [DataType(DataType.Url)]
    [DisplayName("Ed-Fi API URL")]
    [Description("The URL of the Ed-Fi API instance to connect to.")]
    public string EdFiApiUrl { get; set; } = default!;

    [DataType(DataType.Text)]
    [Description("The key to connect to the Ed-Fi API instance specified in Ed-Fi API URL.")]
    public string Key { get; set; } = default!;

    [DataType(DataType.Text)]
    [Description("The secret to connect to the Ed-Fi API instance specified in Ed-Fi API URL.")]
    public string Secret { get; set; } = default!;
}