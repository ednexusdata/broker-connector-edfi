using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using EdNexusData.Broker.Common.StudentLookup;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Services;

public class StudentLookupService : IStudentLookupService
{
   private readonly OAuthTokenResolver _tokenResolver;

   public StudentLookupService(OAuthTokenResolver tokenResolver)
   {
        _tokenResolver = tokenResolver;
   }

   public async Task<List<StudentLookupResult>> SearchAsync(Common.Students.Student studentParameters)
   {
        var configuration = await _tokenResolver.Resolve();

        var edfiStudentsApi = new StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach(var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult() {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = DateOnly.FromDateTime(edfiResult.BirthDate),
                    Additional = new Dictionary<string, object> {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
   }
}