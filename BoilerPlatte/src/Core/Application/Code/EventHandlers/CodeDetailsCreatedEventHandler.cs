using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeDetailsCreatedEventHandler : INotificationHandler<EventNotification<CodeDetailsCreatedEvent>>
{
    private readonly ILogger<CodeDetailsCreatedEventHandler> _logger;

    public CodeDetailsCreatedEventHandler(ILogger<CodeDetailsCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeDetailsCreatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
