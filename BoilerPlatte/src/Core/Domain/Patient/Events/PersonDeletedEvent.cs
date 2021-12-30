using BoilerPlatte.Domain.Common.Contracts;

namespace BoilerPlatte.Domain.Patient.Events;

public class PersonDeletedEvent : DomainEvent
{
    public PersonDeletedEvent(Person person)
    {
        Person = person;
    }

    public Person Person { get; }
}
