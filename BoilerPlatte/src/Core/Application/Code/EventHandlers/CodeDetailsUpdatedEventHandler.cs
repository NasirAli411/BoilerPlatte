using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeDetailsUpdatedEventHandler : INotificationHandler<EventNotification<CodeDetailsUpdatedEvent>>
{
    private readonly ILogger<CodeDetailsUpdatedEventHandler> _logger;

    public CodeDetailsUpdatedEventHandler(ILogger<CodeDetailsUpdatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeDetailsUpdatedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
