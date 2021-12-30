using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Application.Common.Interfaces;

public interface IEventService : ITransientService
{
    Task PublishAsync(DomainEvent domainEvent);
}
