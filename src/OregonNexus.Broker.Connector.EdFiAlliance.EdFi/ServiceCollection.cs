using Microsoft.Extensions.DependencyInjection;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi;

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