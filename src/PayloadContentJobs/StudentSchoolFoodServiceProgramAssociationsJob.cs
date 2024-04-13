using EdFi.OdsApi.Sdk.Apis.All;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContents;
using EdNexusData.Broker.Connector.PayloadContentTypes;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

public class StudentSchoolFoodServiceProgramAssociationsJob : IPayloadContentJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentSchoolFoodServiceProgramAssociationsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
    {
        var configuration = await _tokenResolver.Resolve();
        
        var api = new StudentSchoolFoodServiceProgramAssociationsApi(configuration);
        var response = await api.GetStudentSchoolFoodServiceProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentSchoolFoodServiceProgramAssociationsPayloadContent()
        {
            Content = response.Data
        };

        return dataContent;
    }
}
