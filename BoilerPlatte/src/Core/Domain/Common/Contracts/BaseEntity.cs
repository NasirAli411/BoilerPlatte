using MassTransit;

namespace BoilerPlatte.Domain.Common.Contracts;

public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public List<DomainEvent> DomainEvents = new();

    protected BaseEntity()
    {
        Id = NewId.Next().ToGuid();
    }
}
