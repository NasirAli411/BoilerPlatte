using BoilerPlatte.Shared.DTOs.Filters;

namespace BoilerPlatte.Shared.DTOs.Catalog;

public class ProductListFilter : PaginationFilter
{
    public Guid? BrandId { get; set; }
    public decimal? MinimumRate { get; set; }
    public decimal? MaximumRate { get; set; }
}
