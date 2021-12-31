namespace BoilerPlatte.Shared.DTOs.Patient;

public class ContactDto : IDto
{
    public Guid Id { get; set; }
    public string Type { get; private set; }
    public string PrimaryContact { get; set; }
    public string Tenant { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string Address3 { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
}
