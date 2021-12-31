using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class ContactCreatedEvent : DomainEvent
{
    public ContactCreatedEvent(Contact contact)
    {
        Contact = contact;
    }

    public Contact Contact { get; }
}
