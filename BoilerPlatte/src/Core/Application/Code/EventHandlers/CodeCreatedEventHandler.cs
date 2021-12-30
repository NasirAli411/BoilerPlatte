using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeCreatedEventHandler : INotificationHandler<EventNotification<CodeCreatedEvent>>
{
    private readonly ILogger<CodeCreatedEventHandler> _logger;

    public CodeCreatedEventHandler(ILogger<CodeCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeCreatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
