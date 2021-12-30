using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using BoilerPlatte.Domain.Patient.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeUpdatedEventHandler : INotificationHandler<EventNotification<CodeUpdatedEvent>>
{
    private readonly ILogger<CodeUpdatedEventHandler> _logger;

    public CodeUpdatedEventHandler(ILogger<CodeUpdatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
