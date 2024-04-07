// namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Payloads;
// public class StudentPayload
// {
//     public async Task<StudentCumulativeRecord> GetById(
//         string basePath,
//         string clientKey,
//         string clientSecret,
//         string studentUniqueId,
//         IEnumerable<string> payloadContents)
//     {
//         try
//         {
//             if (string.IsNullOrWhiteSpace(basePath) || string.IsNullOrWhiteSpace(clientKey) || string.IsNullOrWhiteSpace(clientSecret) || string.IsNullOrWhiteSpace(studentUniqueId))
//                 throw new Exception("Required parameters missing.");

//             var accessToken = new TokenRetriever(basePath, clientKey, clientSecret);
            
//             var studentCumulativeRecord = new StudentCumulativeRecord();
//             var tasks = new List<Task>();

//             foreach (var payload in payloadContents)
//             {
//                 var type = Type.GetType(payload);
//                 if (type != null)
//                 {
//                     var method = type.GetMethod("ExecuteAsync");
//                     if (method != null)
//                     {
//                             var instance = Activator.CreateInstance(type);
//                             type.GetProperty("BasePath")?.SetValue(instance, basePath);
//                             type.GetProperty("StudentUniqueId")?.SetValue(instance, studentUniqueId);
//                             var payloadTask = (Task)method.Invoke(instance, null);
//                             tasks.Add(payloadTask);
//                     }
//                 }
//             }

//             await Task.WhenAll(tasks);
//             studentCumulativeRecord.PayloadContents.AddRange(
//                 tasks.Where(task => task.Status == TaskStatus.RanToCompletion)
//                 .Select(task => (string)task.GetType().GetProperty("Result").GetValue(task)));

//             return studentCumulativeRecord;

//         }
//         catch (Exception ex)
//         {
//             throw new Exception("Failed to retrieve payload contents.", ex);
//         }
//     }
// }
