using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using EdNexusData.Broker.Connector.Configuration;
using EdNexusData.Broker.Domain;
using EdNexusData.Broker.Connector.StudentLookup;
using EdFi.OdsApi.Sdk.Apis.All;
using EdFiOdsSdk = EdFi.OdsApi.Sdk.Client;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Configuration;
using EdNexusData.Broker.Connector.Resolvers;
using EdNexusData.Broker.Connector.Student;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Services;

public class StudentLookupService : IStudentLookupService
{
   private readonly IConfigurationResolver _configurationResolver;

   public StudentLookupService(IConfigurationResolver configurationResolver)
   {
        _configurationResolver = configurationResolver;
   }

   public async Task<List<StudentLookupResult>> SearchAsync(Domain.Student studentParameters)
   {
        var connection = await _configurationResolver.FetchConnectorSettingsAsync<Connection>();
        
        // TokenRetriever makes the oauth calls.  It has RestSharp dependency, install via NuGet
        var tokenRetriever = new TokenRetriever(connection.EdFiApiUrl, connection.Key, connection.Secret);

        // Plug Oauth access token. Tokens will need to be refreshed when they expire
        var configuration = new EdFiOdsSdk.Configuration()
        {
            AccessToken = await tokenRetriever.ObtainNewBearerToken(),
            BasePath = $"{connection.EdFiApiUrl}/data/v3"
        };

        // New up StudentsApi
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