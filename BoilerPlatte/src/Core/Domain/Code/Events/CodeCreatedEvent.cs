using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeCreatedEvent : DomainEvent
{
    public CodeCreatedEvent(Codess code)
    {
        Code = code;
    }

    public Codess Code { get; }
}
