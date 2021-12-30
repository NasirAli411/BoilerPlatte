using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Shared.DTOs.Multitenancy;

namespace BoilerPlatte.Application.Multitenancy;

public interface ITenantService : IScopedService
{
    public string GetDatabaseProvider();

    public string GetConnectionString();

    public TenantDto GetCurrentTenant();

    public void SetCurrentTenant(string tenant);
}
