using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Assessments")]
public class StudentAssessmentsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsJob(OAuthTokenResolver tokenResolver)
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
                var v54 = new StudentAssessmentsV54Job(_tokenResolver);
                return await v54.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v62.Client.Configuration _:
                var v62 = new StudentAssessmentsV62Job(_tokenResolver);
                return await v62.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v71.Client.Configuration _:
                var v71 = new StudentAssessmentsV71Job(_tokenResolver);
                return await v71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var v72 = new StudentAssessmentsV72Job(_tokenResolver);
                return await v72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var v73 = new StudentAssessmentsV73Job(_tokenResolver);
                return await v73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}

public class StudentAssessmentsV54Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsV54Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v54.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v54.Apis.All.StudentAssessmentsApi(config);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsV54PayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}

public class StudentAssessmentsV62Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsV62Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v62.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v62.Apis.All.StudentAssessmentsApi(config);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsV62PayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}

public class StudentAssessmentsV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.StudentAssessmentsApi(config);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsV71PayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}

public class StudentAssessmentsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.StudentAssessmentsApi(config);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsV72PayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}

public class StudentAssessmentsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentAssessmentsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.StudentAssessmentsApi(config);
        var response = await api.GetStudentAssessmentsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentAssessmentsV73PayloadContent()
        {
            Content = response.Data
        };

        if (response.Data.Count() > 0)
        {
            return dataContent;
        }

        return null;
    }
}