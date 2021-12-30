using BoilerPlatte.Domain.Common.Contracts;
using MediatR;

namespace BoilerPlatte.Application.Common.Event;

public class EventNotification<T> : INotification
where T : DomainEvent
{
    public EventNotification(T domainEvent)
    {
        DomainEvent = domainEvent;
    }

    public T DomainEvent { get; }
}
