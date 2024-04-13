// using EdFi.OdsApi.Sdk.Apis.All;
// using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
// using EdNexusData.Broker.Connector.PayloadContents;
// using EdNexusData.Broker.Connector.PayloadContentTypes;

// namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

// public class StudentProgramEvaluationsJob : IPayloadContentJob
// {
//     private readonly OAuthTokenResolver _tokenResolver;

//     public StudentProgramEvaluationsJob(OAuthTokenResolver tokenResolver)
//     {
//         _tokenResolver = tokenResolver;
//     }

//     public async Task<PayloadContentType> ExecuteAsync(string studentUniqueId)
//     {
//         var configuration = await _tokenResolver.Resolve();
        
//         var api = new StudentProgramEvaluationsApi(configuration);
//         var response = await api.GetStudentProgramEvaluationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

//         var dataContent = new StudentProgramEvaluationsPayloadContent()
//         {
//             Content = response.Data
//         };

//         return dataContent;
//     }
// }
