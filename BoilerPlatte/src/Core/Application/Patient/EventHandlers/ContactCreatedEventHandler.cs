using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Catalog.Events;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class ContactCreatedEventHandler : INotificationHandler<EventNotification<ContactCreatedEvent>>
{
    private readonly ILogger<ContactCreatedEventHandler> _logger;

    public ContactCreatedEventHandler(ILogger<ContactCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<ContactCreatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
