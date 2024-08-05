using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Special Education Programs Eligibility")]
public class StudentSpecialEducationProgramEligibilityAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentSpecialEducationProgramEligibilityAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentSpecialEducationProgramEligibilityAssociationsApi(config);
        var response = await api.GetStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentSpecialEducationProgramEligibilityAssociationsPayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}
