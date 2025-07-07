using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Common.PayloadContents;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Course Transcripts")]
public class CourseTranscriptsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public CourseTranscriptsJob(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public override async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration,
        IJobStatusService jobStatusService
    )
    {
        var tokenConfiguration = await _tokenResolver.Resolve();

        switch (tokenConfiguration)
        {
            case EdFiOdsSdk.v54.Client.Configuration _:
                var courseTranscriptJobv54 = new CourseTranscriptsV54Job(_tokenResolver);
                return await courseTranscriptJobv54.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v62.Client.Configuration _:
                var courseTranscriptJobv62 = new CourseTranscriptsV62Job(_tokenResolver);
                return await courseTranscriptJobv62.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v71.Client.Configuration _:
                var courseTranscriptJobv71 = new CourseTranscriptsV71Job(_tokenResolver);
                return await courseTranscriptJobv71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var courseTranscriptJobv72 = new CourseTranscriptsV72Job(_tokenResolver);
                return await courseTranscriptJobv72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var courseTranscriptJobv73 = new CourseTranscriptsV73Job(_tokenResolver);
                return await courseTranscriptJobv73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}


public class CourseTranscriptsV54Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiOdsSdk.v54.Models.All.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiOdsSdk.v54.Models.All.EdFiCourse> courseRecords = new List<EdFiOdsSdk.v54.Models.All.EdFiCourse>();

    private EdFiOdsSdk.v54.Client.Configuration? config;

    public CourseTranscriptsV54Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = (EdFiOdsSdk.v54.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v54.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsV54PayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursesV54PayloadContent()
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
                    var api = new EdFiOdsSdk.v54.Apis.All.CoursesApi(config);
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

public class CourseTranscriptsV62Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiOdsSdk.v62.Models.All.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiOdsSdk.v62.Models.All.EdFiCourse> courseRecords = new List<EdFiOdsSdk.v62.Models.All.EdFiCourse>();

    private EdFiOdsSdk.v62.Client.Configuration? config;

    public CourseTranscriptsV62Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = (EdFiOdsSdk.v62.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v62.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsV62PayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursesV62PayloadContent()
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
                    var api = new EdFiOdsSdk.v62.Apis.All.CoursesApi(config);
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

public class CourseTranscriptsV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiOdsSdk.v71.Models.All.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiOdsSdk.v71.Models.All.EdFiCourse> courseRecords = new List<EdFiOdsSdk.v71.Models.All.EdFiCourse>();

    private EdFiOdsSdk.v71.Client.Configuration? config;

    public CourseTranscriptsV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsV71PayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursesV71PayloadContent()
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
                    var api = new EdFiOdsSdk.v71.Apis.All.CoursesApi(config);
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

public class CourseTranscriptsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiOdsSdk.v72.Models.All.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiOdsSdk.v72.Models.All.EdFiCourse> courseRecords = new List<EdFiOdsSdk.v72.Models.All.EdFiCourse>();

    private EdFiOdsSdk.v72.Client.Configuration? config;

    public CourseTranscriptsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsV72PayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursesV72PayloadContent()
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
                    var api = new EdFiOdsSdk.v72.Apis.All.CoursesApi(config);
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

public class CourseTranscriptsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    private List<EdFiOdsSdk.v73.Models.All.EdFiCourseTranscript>? courseTranscriptRecords;
    private List<EdFiOdsSdk.v73.Models.All.EdFiCourse> courseRecords = new List<EdFiOdsSdk.v73.Models.All.EdFiCourse>();

    private EdFiOdsSdk.v73.Client.Configuration? config;

    public CourseTranscriptsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(string studentUniqueId, JsonDocument? configuration)
    {
        config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.CourseTranscriptsApi(config);
        var response = await api.GetCourseTranscriptsWithHttpInfoAsync(studentUniqueId: studentUniqueId);
        courseTranscriptRecords = response.Data;

        await CourseAsync();

        var dataContent = new CourseTranscriptsV73PayloadContent()
        {
            Content = courseTranscriptRecords
        };

        if (courseRecords.Count > 0)
        {
            if (dataContent.AdditionalContents is null)
            {
                dataContent.AdditionalContents = new List<DataPayloadContent>();
            }

            var coursePayloadContents = new CoursesV73PayloadContent()
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
                    var api = new EdFiOdsSdk.v73.Apis.All.CoursesApi(config);
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