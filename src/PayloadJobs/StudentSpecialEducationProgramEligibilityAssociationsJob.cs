using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Special Education Programs Eligibility")]
public class StudentSpecialEducationProgramEligibilityAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentSpecialEducationProgramEligibilityAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentSpecialEducationProgramEligibilityAssociationsApi(configuration);
        var response = await api.GetStudentSpecialEducationProgramEligibilityAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentSpecialEducationProgramEligibilityAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
