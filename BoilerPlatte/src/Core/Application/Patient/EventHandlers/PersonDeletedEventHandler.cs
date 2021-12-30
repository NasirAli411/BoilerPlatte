using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Patient.EventHandlers;

public class PersonDeletedEventHandler : INotificationHandler<EventNotification<PersonDeletedEvent>>
{
    private readonly ILogger<PersonDeletedEventHandler> _logger;

    public PersonDeletedEventHandler(ILogger<PersonDeletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<PersonDeletedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
