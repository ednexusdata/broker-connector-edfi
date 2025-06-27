using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Common.PayloadContents;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;
using EdFiSdk = EdFi.OdsApi.Sdk.v71;
using EdFiSdkModels = EdFi.OdsApi.Sdk.v71.Models.All;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Course Transcripts")]
public class CourseTranscriptsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiSdkModels.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiSdkModels.EdFiCourse> courseRecords = new List<EdFiSdkModels.EdFiCourse>(); 

    private EdFiSdk.Client.Configuration? config;

    public CourseTranscriptsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = await _tokenResolver.Resolve();

        var api = new EdFiSdk.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsPayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursePayloadContent()
            {
                Content = courseRecords
            };

            dataContent.AdditionalContents.Add(
                coursePayloadContents
            );
        }

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }

    private async Task CourseAsync()
    {
        if (courseTranscriptRecords is null) return;
        _ = config ?? throw new NullReferenceException("Ed-Fi configuration not loaded");

        foreach (var courseTranscript in courseTranscriptRecords)
        {
            var id = ReferenceHelper.ExtractId(courseTranscript.CourseReference.Link.Href);
            if (id is not null)
            {
                if (courseRecords.Where(x => x.Id == id).Count() == 0)
                {
                    var api = new EdFiSdk.Apis.All.CoursesApi(config);
                    var response = await api.GetCoursesByIdAsync(id);
                    if (response is not null)
                    {
                        courseRecords.Add(response);
                    }
                }
            }
        }
    }
}
