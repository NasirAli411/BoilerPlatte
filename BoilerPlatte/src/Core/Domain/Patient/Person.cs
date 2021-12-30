using BoilerPlatte.Domain.Common;
using BoilerPlatte.Domain.Common.Contracts;
using BoilerPlatte.Domain.Contracts;

namespace BoilerPlatte.Domain.Patient;

public class Person : AuditableEntity, IMustHaveTenant
{
    public string FullName { get; private set; }
    public string MrnNo { get; private set; }
    public string Tenant { get; set; }
    public string IDTypeCode { get; set; }
    public string IdNo { get; set; }
    public string Address1 { get; set; }
    public string Address2 { get; set; }
    public string CountryCode { get; set; }
    public string PostalCode { get; set; }
    public string PostalCodeOther { get; set; }
    public string City { get; set; }
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

    public Person(string fullName, string mrnNo, string iDTypeCode, string idNo, string address1, string address2, string countryCode, string postalCode, string postalCodeOther, string city, string state, string stateCode, string phone1, string phone2, string email, DateTime birthDate, string genderCode, string raceCode, string religionCode, string maritalStatusCode, string nationalityCode, byte image, string patientMergeStatus, int patientMergedWithPatientId)
    {
        FullName = fullName;
        MrnNo = mrnNo;
        IDTypeCode = iDTypeCode;
        IdNo = idNo;
        Address1 = address1;
        Address2 = address2;
        CountryCode = countryCode;
        PostalCode = postalCode;
        PostalCodeOther = postalCodeOther;
        City = city;
        State = state;
        StateCode = stateCode;
        Phone1 = phone1;
        Phone2 = phone2;
        Email = email;
        BirthDate = birthDate;
        GenderCode = genderCode;
        RaceCode = raceCode;
        ReligionCode = religionCode;
        MaritalStatusCode = maritalStatusCode;
        NationalityCode = nationalityCode;
        Image = image;
        PatientMergeStatus = patientMergeStatus;
        PatientMergedWithPatientId = patientMergedWithPatientId;
    }

    public Person Update(string fullName, string mrnNo, string iDTypeCode, string idNo, string address1, string address2, string countryCode, string postalCode, string postalCodeOther, string city, string state, string stateCode, string phone1, string phone2, string email, DateTime birthDate, string genderCode, string raceCode, string religionCode, string maritalStatusCode, string nationalityCode, byte image, string patientMergeStatus, int patientMergedWithPatientId)
    {
        if (fullName != null && !FullName.NullToString().Equals(fullName))
            FullName = fullName;
        if (mrnNo != null && !MrnNo.NullToString().Equals(mrnNo))
            MrnNo = mrnNo;
        if (iDTypeCode != null && !IDTypeCode.NullToString().Equals(iDTypeCode))
            IDTypeCode = iDTypeCode;
        if (idNo != null && !IdNo.NullToString().Equals(idNo))
            IdNo = idNo;
        if (address1 != null && !Address1.NullToString().Equals(address1))
            Address1 = address1;
        if (address2 != null && !Address2.NullToString().Equals(address2))
            Address2 = address2;
        if (countryCode != null && !CountryCode.NullToString().Equals(countryCode))
            CountryCode = countryCode;
        if (postalCode != null && !PostalCode.NullToString().Equals(postalCode))
            PostalCode = postalCode;
        if (postalCodeOther != null && !PostalCodeOther.NullToString().Equals(postalCodeOther))
            PostalCodeOther = postalCodeOther;
        if (city != null && !City.NullToString().Equals(city))
            City = city;
        if (state != null && !State.NullToString().Equals(state))
            State = state;
        if (stateCode != null && !StateCode.NullToString().Equals(stateCode))
            StateCode = stateCode;
        if (phone1 != null && !Phone1.NullToString().Equals(phone1))
            Phone1 = phone1;
        if (phone2 != null && !Phone2.NullToString().Equals(phone2))
            Phone2 = phone2;
        if (email != null && !Email.NullToString().Equals(email))
            Email = email;
        if (!BirthDate.Equals(birthDate))
            BirthDate = birthDate;
        if (genderCode != null && !GenderCode.NullToString().Equals(genderCode))
            GenderCode = genderCode;
        if (raceCode != null && !RaceCode.NullToString().Equals(raceCode))
            RaceCode = raceCode;
        if (religionCode != null && !ReligionCode.NullToString().Equals(religionCode))
            ReligionCode = religionCode;
        if (maritalStatusCode != null && !MaritalStatusCode.NullToString().Equals(maritalStatusCode))
            MaritalStatusCode = maritalStatusCode;
        if (nationalityCode != null && !NationalityCode.NullToString().Equals(nationalityCode))
            NationalityCode = nationalityCode;
        if (!Image.Equals(image))
            Image = image;
        if (patientMergeStatus != null && !PatientMergeStatus.NullToString().Equals(patientMergeStatus))
            PatientMergeStatus = patientMergeStatus;
        if (!PatientMergedWithPatientId.NullToString().Equals(patientMergedWithPatientId))
            PatientMergedWithPatientId = patientMergedWithPatientId;
        return this;
    }
}
