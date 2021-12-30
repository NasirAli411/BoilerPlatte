using BoilerPlatte.Shared.DTOs.Filters;

namespace BoilerPlatte.Shared.DTOs.Identity;

public class UserListFilter : PaginationFilter
{
    public bool? IsActive { get; set; }
}
