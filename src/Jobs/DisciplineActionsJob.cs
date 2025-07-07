using EdNexusData.Broker.Common.Jobs;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

[DisplayName("Discipline Actions")]
public class DisciplineActionsJob : PayloadJob
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsJob(OAuthTokenResolver tokenResolver)
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
                var disciplineActionsJobv54 = new DisciplineActionsV54Job(_tokenResolver);
                return await disciplineActionsJobv54.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v62.Client.Configuration _:
                var disciplineActionsJobv62 = new DisciplineActionsV62Job(_tokenResolver);
                return await disciplineActionsJobv62.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v71.Client.Configuration _:
                var disciplineActionsJobv71 = new DisciplineActionsV71Job(_tokenResolver);
                return await disciplineActionsJobv71.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v72.Client.Configuration _:
                var disciplineActionsJobv72 = new DisciplineActionsV72Job(_tokenResolver);
                return await disciplineActionsJobv72.ExecuteAsync(studentUniqueId, configuration);
            case EdFiOdsSdk.v73.Client.Configuration _:
                var disciplineActionsJobv73 = new DisciplineActionsV73Job(_tokenResolver);
                return await disciplineActionsJobv73.ExecuteAsync(studentUniqueId, configuration);
            default:
                return null;
        }
    }
}

public class DisciplineActionsV54Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsV54Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v54.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v54.Apis.All.DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsV54PayloadContent()
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

public class DisciplineActionsV62Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsV62Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v62.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v62.Apis.All.DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsV62PayloadContent()
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

public class DisciplineActionsV71Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsV71Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v71.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v71.Apis.All.DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsV71PayloadContent()
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

public class DisciplineActionsV72Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsV72Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v72.Client.Configuration)await _tokenResolver.Resolve();

        var api = new EdFiOdsSdk.v72.Apis.All.DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsV72PayloadContent()
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

public class DisciplineActionsV73Job
{
    private readonly OAuthTokenResolver _tokenResolver;

    public DisciplineActionsV73Job(OAuthTokenResolver tokenResolver)
    {
        _tokenResolver = tokenResolver;
    }

    public async Task<object?> ExecuteAsync(
        string studentUniqueId,
        JsonDocument? configuration
    )
    {
        var config = (EdFiOdsSdk.v73.Client.Configuration)await _tokenResolver.Resolve();
        
        var api = new EdFiOdsSdk.v73.Apis.All.DisciplineActionsApi(config);
        var response = await api.GetDisciplineActionsWithHttpInfoAsync(studentUniqueId: studentUniqueId);

        var dataContent = new DisciplineActionsV73PayloadContent()
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