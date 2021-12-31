using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class ContactUpdatedEvent : DomainEvent
{
    public ContactUpdatedEvent(Contact contact)
    {
        Contact = contact;
    }

    public Contact Contact { get; }
}
