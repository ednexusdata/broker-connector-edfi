// using EdFi.OdsApi.Sdk.Apis.All;
// using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
// using EdNexusData.Broker.Connector.PayloadContents;

// namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

// public class StudentResourceJob : IPayloadContentJob
// {
//     private readonly string _basePath;
//     private readonly string _studentUniqueId;
    
//     public StudentResourceJob(
//         string basePath,
//         string studentUniqueId)
//     {
//         _basePath = basePath;
//         _studentUniqueId = studentUniqueId;
//     }
    
//     public async Task<StudentResourcePayloadContent> ExecuteAsync(string studentUniqueId)
//     {
//         var payloadContent = new StudentResourcePayloadContent()
//         {
//             BasePath = _basePath,
//             StudentUniqueId = _studentUniqueId
//         };
        
//         await payloadContent.ExecuteAsync();
//         return payloadContent;
//     }

// }
