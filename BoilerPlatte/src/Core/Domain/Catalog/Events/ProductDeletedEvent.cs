using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Catalog.Events;

public class ProductDeletedEvent : DomainEvent
{
    public ProductDeletedEvent(Product product)
    {
        Product = product;
    }

    public Product Product { get; }
}
