using Microsoft.Extensions.DependencyInjection;

namespace ExemploDI;

public interface ITransientService : IReportServiceLifeTime
{
    ServiceLifetime IReportServiceLifeTime.LifeTime => 
        ServiceLifetime.Transient;
}