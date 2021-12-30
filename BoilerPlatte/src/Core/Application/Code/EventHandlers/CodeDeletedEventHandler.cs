using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeDeletedEventHandler : INotificationHandler<EventNotification<CodeDeletedEvent>>
{
    private readonly ILogger<CodeDeletedEventHandler> _logger;

    public CodeDeletedEventHandler(ILogger<CodeDeletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeDeletedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
