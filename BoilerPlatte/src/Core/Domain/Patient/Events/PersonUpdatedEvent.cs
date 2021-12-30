using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class PersonUpdatedEvent : DomainEvent
{
    public PersonUpdatedEvent(Person person)
    {
        Person = person;
    }

    public Person Person { get; }
}
