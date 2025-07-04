using EdNexusData.Broker.Common.Mappings;
using Microsoft.AspNetCore.Mvc.Rendering;
using EdFiOdsApi = EdFi.OdsApi.Sdk;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.ConfigurationLookups;

public class EdFiVersionConfigurationLookup : IMappingLookup
{
    public Task<List<SelectListItem>> SelectListAsync()
    {
        return Task.Run(() => {
            var selectList = new List<SelectListItem>();

            var results = EdFiOdsApi.Constants.Versions;

            if (results is not null && results.Count > 0)
            {
                foreach (var result in results)
                {
                    selectList.Add(new SelectListItem()
                    {
                        Text = $"{result.Value}",
                        Value = result.Key,
                        Selected = false
                    });
                }
            }

            return selectList;
        });
    }
}