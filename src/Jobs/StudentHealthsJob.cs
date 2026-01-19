using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Healths")]
public class StudentHealthsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentHealthsJob(OAuthTokenResolver tokenResolver)
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
            case EdFiOdsSdk.v72.Client.Configuration _:
                var v72 = new StudentHealthsV72Job(_tokenResolver);
                return await v72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var v73 = new StudentHealthsV73Job(_tokenResolver);
                return await v73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}


public class StudentHealthsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentHealthsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.StudentHealthsApi(config);
        var response = await api.GetStudentHealthsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramAssociationsV72PayloadContent()
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

public class StudentHealthsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentHealthsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.StudentHealthsApi(config);
        var response = await api.GetStudentHealthsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentProgramAssociationsV73PayloadContent()
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