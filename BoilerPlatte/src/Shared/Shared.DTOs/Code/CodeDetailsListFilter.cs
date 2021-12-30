using BoilerPlatte.Shared.DTOs.Filters;

namespace BoilerPlatte.Shared.DTOs.Code;

public class CodeDetailsListFilter : PaginationFilter
{
    public string CodeDetailId { get; set; }
    public string Description { get; set; }
    public string CodeValue1 { get; set; }
    public string CodeValue2 { get; set; }
    public string CodeValue3 { get; set; }
    public int Sequence { get; set; }
    public bool IsDefaultCode { get; set; }
}
