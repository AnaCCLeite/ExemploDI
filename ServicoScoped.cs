namespace ExemploDI;

public class Servicoscoped : ISingletonService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}