using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Catalog.Events;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class PersonCreatedEventHandler : INotificationHandler<EventNotification<PersonCreatedEvent>>
{
    private readonly ILogger<PersonCreatedEventHandler> _logger;

    public PersonCreatedEventHandler(ILogger<PersonCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<PersonCreatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
