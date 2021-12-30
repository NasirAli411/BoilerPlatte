using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Catalog.Events;

public class ProductCreatedEvent : DomainEvent
{
    public ProductCreatedEvent(Product product)
    {
        Product = product;
    }

    public Product Product { get; }
}
