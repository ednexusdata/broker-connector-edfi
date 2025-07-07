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

        List<StudentLookupResult> students;

        switch (configuration)
        {
            case EdFiOdsSdk.v54.Client.Configuration _:
                students = await SearchAsyncV54(studentParameters, (EdFiOdsSdk.v54.Client.Configuration)configuration);
                break;
            case EdFiOdsSdk.v62.Client.Configuration _:
                students = await SearchAsyncV62(studentParameters, (EdFiOdsSdk.v62.Client.Configuration)configuration);
                break;
            case EdFiOdsSdk.v71.Client.Configuration _:
                students = await SearchAsyncV71(studentParameters, (EdFiOdsSdk.v71.Client.Configuration)configuration);
                break;
            case EdFiOdsSdk.v72.Client.Configuration _:
                students = await SearchAsyncV72(studentParameters, (EdFiOdsSdk.v72.Client.Configuration)configuration);
                break;
            default:
                students = await SearchAsyncV73(studentParameters, (EdFiOdsSdk.v73.Client.Configuration)configuration);
                break;
        }

        return students;
    }

    public async Task<List<StudentLookupResult>> SearchAsyncV54(
        Common.Students.Student studentParameters,
        EdFiOdsSdk.v54.Client.Configuration configuration
    )
    {
        var edfiStudentsApi = new EdFiOdsSdk.v54.Apis.All.StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach (var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult()
                {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = edfiResult.BirthDate,
                    Additional = new Dictionary<string, object>
                    {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
    }

    public async Task<List<StudentLookupResult>> SearchAsyncV62(
        Common.Students.Student studentParameters,
        EdFiOdsSdk.v62.Client.Configuration configuration
    )
    {
        var edfiStudentsApi = new EdFiOdsSdk.v62.Apis.All.StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach (var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult()
                {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = edfiResult.BirthDate,
                    Additional = new Dictionary<string, object>
                    {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
    }

    public async Task<List<StudentLookupResult>> SearchAsyncV71(
        Common.Students.Student studentParameters,
        EdFiOdsSdk.v71.Client.Configuration configuration
    )
    {
        var edfiStudentsApi = new EdFiOdsSdk.v71.Apis.All.StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach (var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult()
                {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = edfiResult.BirthDate,
                    Additional = new Dictionary<string, object>
                    {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
    }

    public async Task<List<StudentLookupResult>> SearchAsyncV72(
        Common.Students.Student studentParameters,
        EdFiOdsSdk.v72.Client.Configuration configuration
    )
    {
        var edfiStudentsApi = new EdFiOdsSdk.v72.Apis.All.StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach (var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult()
                {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = edfiResult.BirthDate,
                    Additional = new Dictionary<string, object>
                    {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
    }

    public async Task<List<StudentLookupResult>> SearchAsyncV73(
        Common.Students.Student studentParameters,
        EdFiOdsSdk.v73.Client.Configuration configuration
    )
    {
        var edfiStudentsApi = new EdFiOdsSdk.v73.Apis.All.StudentsApi(configuration);
        var edfiResults = await edfiStudentsApi.GetStudentsAsync(firstName: studentParameters.FirstName);
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(lastSurname: studentParameters.LastName));
        edfiResults.AddRange(await edfiStudentsApi.GetStudentsAsync(studentUniqueId: studentParameters.StudentNumber));

        var results = new List<StudentLookupResult>();

        if (edfiResults is not null && edfiResults.Count > 0)
        {
            foreach (var edfiResult in edfiResults)
            {
                results.Add(new StudentLookupResult()
                {
                    FirstName = edfiResult.FirstName,
                    MiddleName = edfiResult.MiddleName,
                    LastName = edfiResult.LastSurname,
                    StudentId = edfiResult.StudentUniqueId,
                    Gender = edfiResult.BirthSexDescriptor,
                    BirthDate = edfiResult.BirthDate,
                    Additional = new Dictionary<string, object>
                    {
                        [typeof(Student).FullName!] = edfiResult
                    }
                });
            }
        }

        return results;
    }
}