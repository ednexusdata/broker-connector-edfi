using Microsoft.Extensions.DependencyInjection;
using EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Jobs;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi;

public class ServiceCollection : IConnectorServiceCollection
{
    /*
    public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
    */

    public static IServiceCollection AddDependencies(IServiceCollection services)
    {
        services.AddScoped<OAuthTokenResolver>();
        
        return services;
    }
}