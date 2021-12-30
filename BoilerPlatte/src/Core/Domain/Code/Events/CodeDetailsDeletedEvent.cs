using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Code.Events;

public class CodeDetailsDeletedEvent : DomainEvent
{
    public CodeDetailsDeletedEvent(CodeDetails codeDetails)
    {
        CodeDetails = codeDetails;
    }

    public CodeDetails CodeDetails { get; }
}
