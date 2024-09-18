namespace ExemploDI;

public class ServicoTransient : ITransientService
{
    Guid IRerportServiceLifeTime.Id { get; } = Guid.NewGuid();
}

public class ServicoScoped : IScopedService
{
    Guid
}