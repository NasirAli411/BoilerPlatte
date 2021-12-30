using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeUpdatedEvent : DomainEvent
{
    public CodeUpdatedEvent(Codess code)
    {
        Code = code;
    }

    public Codess Code { get; }
}
