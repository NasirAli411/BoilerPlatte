using BoilerPlatte.Application.Common.Event;
using BoilerPlatte.Domain.Code.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BoilerPlatte.Application.Code.EventHandlers;

public class CodeDetailsDeleteEventHandler : INotificationHandler<EventNotification<CodeDetailsDeletedEvent>>
{
    private readonly ILogger<CodeDetailsDeleteEventHandler> _logger;

    public CodeDetailsDeleteEventHandler(ILogger<CodeDetailsDeleteEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(EventNotification<CodeDetailsDeletedEvent> notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("{event} Triggered", notification.DomainEvent.GetType().Name);
        return Task.CompletedTask;
    }
}
