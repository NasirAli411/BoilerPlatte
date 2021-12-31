using BoilerPlatte.Domain.Common;
using BoilerPlatte.Domain.Common.Contracts;
using BoilerPlatte.Domain.Contracts;

namespace BoilerPlatte.Domain.Patient;

public class Contact : AuditableEntity, IMustHaveTenant
{
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

    public Contact(string type, string primaryContact, string address1, string address2, string address3, string postCode, string city, string state, string postalCode, string phone1, string phone2)
    {
        Type = type;
        PrimaryContact = primaryContact;
        Address1 = address1;
        Address2 = address2;
        Address3 = address3;
        PostalCode = postalCode;
        City = city;
        State = state;
        PostCode = postCode;
        Phone1 = phone1;
        Phone2 = phone2;
    }

    public Contact Update(string type, string pcontact, string address1, string address2, string address3, string postCode, string city, string state, string postalCode, string phone1, string phone2)
    {
        if (type != null && !Type.NullToString().Equals(type))
            Type = type;
        if (pcontact != null && !PrimaryContact.NullToString().Equals(pcontact))
            PrimaryContact = pcontact;
        if (address1 != null && !Address1.NullToString().Equals(address1))
            Address1 = address1;
        if (address2 != null && !Address2.NullToString().Equals(address2))
            Address2 = address2;
        if (address3 != null && !Address3.NullToString().Equals(address3))
            Address3 = address3;
        if (postalCode != null && !PostalCode.NullToString().Equals(postalCode))
            PostalCode = postalCode;
        if (postCode != null && !PostCode.NullToString().Equals(postCode))
            PostCode = postCode;
        if (city != null && !City.NullToString().Equals(city))
            City = city;
        if (state != null && !State.NullToString().Equals(state))
            State = state;
        if (phone1 != null && !Phone1.NullToString().Equals(phone1))
            Phone1 = phone1;
        if (phone2 != null && !Phone2.NullToString().Equals(phone2))
            Phone2 = phone2;
        return this;
    }
}
