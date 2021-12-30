namespace BoilerPlatte.Shared.DTOs.Patient;

public class PersonDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
