using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Catalog.Events;

public class ProductUpdatedEvent : DomainEvent
{
    public ProductUpdatedEvent(Product product)
    {
        Product = product;
    }

    public Product Product { get; }
}
