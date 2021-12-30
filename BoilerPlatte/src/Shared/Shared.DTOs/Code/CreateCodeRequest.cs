using BoilerPlatte.Shared.DTOs.Storage;
namespace BoilerPlatte.Shared.DTOs.Code;

public class CreateCodeRequest : IMustBeValid
{
    public string ShortCode { get; set; }
    public string Description { get; set; }
    public int Sequence { get; set; }
    public bool IsDefaultCode { get; set; }
}
