namespace BoilerPlatte.Shared.DTOs.Code;

public class CodeDetailsDetailsDto : IDto
{
    public string CodeDetailId { get; set; }
    public string Description { get; set; }
    public string CodeValue1 { get; set; }
    public string CodeValue2 { get; set; }
    public string CodeValue3 { get; set; }
    public int Sequence { get; set; }
    public bool IsDefaultCode { get; set; }
}
