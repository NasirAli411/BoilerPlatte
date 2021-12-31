using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class ContactDeletedEvent : DomainEvent
{
    public ContactDeletedEvent(Contact contact)
    {
        Contact = contact;
    }

    public Contact Contact { get; }
}
