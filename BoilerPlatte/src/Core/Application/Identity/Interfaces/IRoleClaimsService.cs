using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Identity;

namespace BoilerPlatte.Application.Abstractions.Services.Identity;

public interface IRoleClaimsService : ITransientService
{
    public Task<bool> HasPermissionAsync(string userId, string permission);

    Task<Result<List<RoleClaimResponse>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

    Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

    Task<Result<string>> SaveAsync(RoleClaimRequest request);

    Task<Result<string>> DeleteAsync(int id);
}
