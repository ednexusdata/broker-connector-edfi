// using System.ComponentModel;
// using System.Text.Json;
// using EdFi.OdsApi.Sdk.Apis.All;
// using Microsoft.Extensions.Logging;
// using EdNexusData.Broker.Connector.PayloadContents;
// using EdNexusData.Broker.Connector.PayloadContentTypes;

// namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

// [DisplayName("Student")]
// public class StudentResourcePayloadContent : DataContentType
// {
//     public override string Schema => "EdFi";
//     public override string SchemaVersion => "3";
//     public override string ContentType => "text/json";
//     public override string Content { 
//         get {
//             return JsonSerializer.Serialize(JsonContent);
//         }
//     }
//     public string BasePath {get;set;}
//     public string StudentUniqueId {get;set;}
//     // public async Task<StudentResourcePayloadContent> ExecuteAsync()
//     // {
//     //     var api = new StudentsApi(BasePath);
//     //     var response = await api.GetStudentsWithHttpInfoAsync(studentUniqueId: StudentUniqueId);
//     //     var httpReponseCode = response.StatusCode;
//     //     var students = response.Data;

//     //     var dataContent = new StudentResourcePayloadContent()
//     //     {
//     //         Content = JsonSerializer.Serialize(students)
//     //     };
//     //     return dataContent;
//     // }
// }
