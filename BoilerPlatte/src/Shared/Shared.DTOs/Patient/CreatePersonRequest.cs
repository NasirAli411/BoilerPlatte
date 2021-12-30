namespace BoilerPlatte.Shared.DTOs.Patient;

public class CreatePersonRequest : IMustBeValid
{
    public string FullName { get; set; }
    public string MrnNo { get; set; }
    public string IDTypeCode { get; set; }
    public string IdNo { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string CountryCode { get; set; }
    public string PostalCode { get; set; }
    public string PostalCodeOther { get; set; }
    public string City { get; set; }
    public string CityCode { get; set; }
    public string State { get; set; }
    public string StateCode { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public string GenderCode { get; set; }
    public string RaceCode { get; set; }
    public string ReligionCode { get; set; }
    public string MaritalStatusCode { get; set; }
    public string NationalityCode { get; set; }
    public byte Image { get; set; }
    public string PatientMergeStatus { get; set; }
    public int PatientMergedWithPatientId { get; set; }
}
