using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class PersonUpdatedEventHandler : INotificationHandler<EventNotification<PersonUpdatedEvent>>
{
    private readonly ILogger<PersonUpdatedEventHandler> _logger;

    public PersonUpdatedEventHandler(ILogger<PersonUpdatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<PersonUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
