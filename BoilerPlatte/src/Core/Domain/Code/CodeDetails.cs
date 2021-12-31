using BoilerPlatte.Domain.Common;
using BoilerPlatte.Domain.Common.Contracts;
using BoilerPlatte.Domain.Contracts;

namespace BoilerPlatte.Domain.Code;

public class CodeDetails : AuditableEntity, IMustHaveTenant
{
    public string CodeDetailId { get; set; }
    public string Description { get; set; }
    public string CodeValue1 { get; set; }
    public string CodeValue2 { get; set; }
    public string CodeValue3 { get; set; }
    public int Sequence { get; set; }
    public bool IsDefaultCode { get; set; }
    public string Tenant { get; set; }
    public CodeDetails(string description, string codeValue1, string codeValue2, string codeValue3, int sequence, bool isDefaultCode)
    {
        Description = description;
        CodeValue1 = codeValue1;
        CodeValue2 = codeValue2;
        CodeValue3 = codeValue3;
        Sequence = sequence;
        IsDefaultCode = isDefaultCode;
    }

    public CodeDetails Update(string description, string codeValue1, string codeValue2, string codeValue3)
    {
        if (description != null && !Description.NullToString().Equals(description)) Description = description;
        if (codeValue1 != null && !CodeValue1.NullToString().Equals(codeValue1)) CodeValue1 = codeValue1;
        if (codeValue2 != null && !CodeValue2.NullToString().Equals(codeValue2)) CodeValue2 = codeValue2;
        if (codeValue3 != null && !CodeValue3.NullToString().Equals(codeValue3)) CodeValue3 = codeValue3;
        return this;
    }

}
