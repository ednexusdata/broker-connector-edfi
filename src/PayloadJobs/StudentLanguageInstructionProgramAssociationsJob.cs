using System.ComponentModel;
using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector;
using System.Text.Json;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Language Instruction Programs")]
public class StudentLanguageInstructionProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentLanguageInstructionProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        var config = await _tokenResolver.Resolve();
        
        var api = new StudentLanguageInstructionProgramAssociationsApi(config);
        var response = await api.GetStudentLanguageInstructionProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentLanguageInstructionProgramAssociationsPayloadContent()
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
