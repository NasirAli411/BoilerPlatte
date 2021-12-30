using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class PersonCreatedEvent : DomainEvent
{
    public PersonCreatedEvent(Person person)
    {
        Person = person;
    }

    public Person Person { get; }
}
