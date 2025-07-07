using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Program Evaluations")]
public class StudentProgramEvaluationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramEvaluationsJob(OAuthTokenResolver tokenResolver)
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
            case EdFiOdsSdk.v71.Client.Configuration _:
                var v71 = new StudentProgramEvaluationsV71Job(_tokenResolver);
                return await v71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var v72 = new StudentProgramEvaluationsV72Job(_tokenResolver);
                return await v72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var v73 = new StudentProgramEvaluationsV73Job(_tokenResolver);
                return await v73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}

public class StudentProgramEvaluationsV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramEvaluationsV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.StudentProgramEvaluationsApi(config);
        var response = await api.GetStudentProgramEvaluationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramEvaluations71PayloadContent()
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

public class StudentProgramEvaluationsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramEvaluationsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.StudentProgramEvaluationsApi(config);
        var response = await api.GetStudentProgramEvaluationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramEvaluations72PayloadContent()
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

public class StudentProgramEvaluationsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentProgramEvaluationsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.StudentProgramEvaluationsApi(config);
        var response = await api.GetStudentProgramEvaluationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramEvaluations73PayloadContent()
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