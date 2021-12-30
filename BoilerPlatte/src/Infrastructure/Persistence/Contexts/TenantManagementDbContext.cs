using BoilerPlatte.Domain.Multitenancy;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlatte.Infrastructure.Persistence.Contexts;

public class TenantManagementDbContext : DbContext
{
    public TenantManagementDbContext(DbContextOptions<TenantManagementDbContext> options)
    : base(options)
    {
    }

    public DbSet<Tenant> Tenants { get; set; }
}
