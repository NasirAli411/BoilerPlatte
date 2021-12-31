using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class ContactDeletedEventHandler : INotificationHandler<EventNotification<ContactDeletedEvent>>
{
    private readonly ILogger<ContactDeletedEventHandler> _logger;

    public ContactDeletedEventHandler(ILogger<ContactDeletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<ContactDeletedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
