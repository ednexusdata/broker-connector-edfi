// using System.ComponentModel;
// using EdFi.OdsApi.Sdk.Models.All;
// using EdNexusData.Broker.Connector.Attributes;
// using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
// using EdNexusData.Broker.Connector.PayloadContentTypes;
// using EdNexusData.Broker.Core;

// namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

// [Job(typeof(StudentProgramEvaluationsJob))]
// [DisplayName("Student Program Evaluations")]
// public class StudentProgramEvaluationsPayloadContent : PayloadContentType
// {
//     public override PayloadContentSchema Schema => new PayloadContentSchema()
//     {
//         Owner = "EdFi",
//         Schema = "EdFi.Resources.StudentProgramEvaluations",
//         ObjectType = typeof(StudentProgramEvaluationsPayloadContent).FullName!,
//         ContentObjectType = typeof(EdFiStudentProgramEvaluation).FullName!,
//         SchemaVersion = "5.0.0"
//     };

// }
