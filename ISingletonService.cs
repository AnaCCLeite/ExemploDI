using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface ISingletonService : IReportServiceLifeTime
{
    ServiceLifetime IReportServiceLifeTime.LifeTime => 
        ServiceLifetime.Singleton;
}