using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Competency Objectives")]
public class StudentCompetencyObjectivesJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesJob(OAuthTokenResolver tokenResolver)
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
                var v54 = new StudentCompetencyObjectivesV54Job(_tokenResolver);
                return await v54.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v62.Client.Configuration _:
                var v62 = new StudentCompetencyObjectivesV62Job(_tokenResolver);
                return await v62.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v71.Client.Configuration _:
                var v71 = new StudentCompetencyObjectivesV71Job(_tokenResolver);
                return await v71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var v72 = new StudentCompetencyObjectivesV72Job(_tokenResolver);
                return await v72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var v73 = new StudentCompetencyObjectivesV73Job(_tokenResolver);
                return await v73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}

public class StudentCompetencyObjectivesV54Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesV54Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v54.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v54.Apis.All.StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesV54PayloadContent()
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

public class StudentCompetencyObjectivesV62Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesV62Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v62.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v62.Apis.All.StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesV62PayloadContent()
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

public class StudentCompetencyObjectivesV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesV71PayloadContent()
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

public class StudentCompetencyObjectivesV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesV72PayloadContent()
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

public class StudentCompetencyObjectivesV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentCompetencyObjectivesV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.StudentCompetencyObjectivesApi(config);
        var response = await api.GetStudentCompetencyObjectivesWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentCompetencyObjectivesV73PayloadContent()
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