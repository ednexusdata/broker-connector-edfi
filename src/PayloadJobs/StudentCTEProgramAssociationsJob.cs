using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student CTE Programs")]
public class StudentCTEProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCTEProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentCTEProgramAssociationsApi(configuration);
        var response = await api.GetStudentCTEProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCTEProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
