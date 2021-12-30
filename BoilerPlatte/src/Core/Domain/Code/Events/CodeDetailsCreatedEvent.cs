using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeDetailsCreatedEvent : DomainEvent
{
    public CodeDetailsCreatedEvent(CodeDetails codeDetails)
    {
        CodeDetails = codeDetails;
    }

    public CodeDetails CodeDetails { get; }
}
