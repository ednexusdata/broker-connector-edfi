using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Cohorts")]
public class StudentCohortAssocationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCohortAssocationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentCohortAssociationsApi(configuration);
        var response = await api.GetStudentCohortAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCohortAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
