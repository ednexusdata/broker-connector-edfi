using System.Text.RegularExpressions;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi;

public static class ReferenceHelper
{
    public static string? ExtractId(string href)
    {
        string pattern = @"[^/]+$";
        
        Regex regex = new Regex(pattern);
        Match match = regex.Match(href);

        return match.Success ? match.Value : null;
    }
}
