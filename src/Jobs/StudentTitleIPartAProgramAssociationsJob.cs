using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Student Title I Part A Programs")]
public class StudentTitleIPartAProgramAssociationsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsJob(OAuthTokenResolver tokenResolver)
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
                var v54 = new StudentTitleIPartAProgramAssociationsV54Job(_tokenResolver);
                return await v54.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v62.Client.Configuration _:
                var v62 = new StudentTitleIPartAProgramAssociationsV62Job(_tokenResolver);
                return await v62.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v71.Client.Configuration _:
                var v71 = new StudentTitleIPartAProgramAssociationsV71Job(_tokenResolver);
                return await v71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var v72 = new StudentTitleIPartAProgramAssociationsV72Job(_tokenResolver);
                return await v72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var v73 = new StudentTitleIPartAProgramAssociationsV73Job(_tokenResolver);
                return await v73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}

public class StudentTitleIPartAProgramAssociationsV54Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsV54Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v54.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v54.Apis.All.StudentTitleIPartAProgramAssociationsApi(config);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsV54PayloadContent()
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

public class StudentTitleIPartAProgramAssociationsV62Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsV62Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v62.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v62.Apis.All.StudentTitleIPartAProgramAssociationsApi(config);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsV62PayloadContent()
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

public class StudentTitleIPartAProgramAssociationsV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.StudentTitleIPartAProgramAssociationsApi(config);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsV71PayloadContent()
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

public class StudentTitleIPartAProgramAssociationsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.StudentTitleIPartAProgramAssociationsApi(config);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsV72PayloadContent()
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

public class StudentTitleIPartAProgramAssociationsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public StudentTitleIPartAProgramAssociationsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v73.Apis.All.StudentTitleIPartAProgramAssociationsApi(config);
        var response = await api.GetStudentTitleIPartAProgramAssociationsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new StudentTitleIPartAProgramAssociationsV73PayloadContent()
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