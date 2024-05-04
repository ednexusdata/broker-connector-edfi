using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Special Education Programs")]
public class StudentSpecialEducationProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentSpecialEducationProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentSpecialEducationProgramAssociationsApi(configuration);
        var response = await api.GetStudentSpecialEducationProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentSpecialEducationProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
