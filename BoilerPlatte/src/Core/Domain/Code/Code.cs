using BoilerPlatte.Domain.Common;
using BoilerPlatte.Domain.Common.Contracts;
using BoilerPlatte.Domain.Contracts;

namespace BoilerPlatte.Domain.Code;

public class Codess : AuditableEntity, IMustHaveTenant
{
    public string ShortCode { get; set; }
    public string Description { get; set; }
    public int Sequence { get; set; }
    public bool IsDefaultCode { get; set; }
    public string Tenant { get; set; }
    public Codess(string shortCode, string description, int sequence, bool isDefaultCode)
    {
        ShortCode = shortCode;
        Description = description;
        Sequence = sequence;
        IsDefaultCode = isDefaultCode;
    }

    public Codess Updates(string shortCode, string description, int sequence, bool isDefaultCode)
    {
        if (shortCode != null && !ShortCode.NullToString().Equals(shortCode)) ShortCode = shortCode;
        if (description != null && !Description.NullToString().Equals(description)) Description = description;
        return this;
    }
}
