using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeDeletedEvent : DomainEvent
{
    public CodeDeletedEvent(Codess code)
    {
        Code = code;
    }

    public Codess Code { get; }
}
