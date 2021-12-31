using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class ContactUpdatedEventHandler : INotificationHandler<EventNotification<ContactUpdatedEvent>>
{
    private readonly ILogger<ContactUpdatedEventHandler> _logger;

    public ContactUpdatedEventHandler(ILogger<ContactUpdatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<ContactUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
