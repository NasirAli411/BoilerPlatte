using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeDetailsUpdatedEvent : DomainEvent
{
    public CodeDetailsUpdatedEvent(CodeDetails codeDetails)
    {
        CodeDetails = codeDetails;
    }

    public CodeDetails CodeDetails { get; }
}
