using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Identity;

namespace BoilerPlatte.Application.Abstractions.Services.Identity;

public interface IUserService : ITransientService
{
    Task<PaginatedResult<UserDetailsDto>> SearchAsync(UserListFilter filter);

    Task<Result<List<UserDetailsDto>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<IResult<UserDetailsDto>> GetAsync(string userId);

    Task<IResult<UserRolesResponse>> GetRolesAsync(string userId);

    Task<IResult<string>> AssignRolesAsync(string userId, UserRolesRequest request);

    Task<Result<List<PermissionDto>>> GetPermissionsAsync(string id);
}
