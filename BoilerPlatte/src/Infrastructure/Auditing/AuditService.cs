using BoilerPlatte.Application.Auditing;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Infrastructure.Persistence.Contexts;
using BoilerPlatte.Shared.DTOs.Auditing;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlatte.Infrastructure.Auditing;

public class AuditService : IAuditService
{
    private readonly ApplicationDbContext _context;

    public AuditService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IResult<IEnumerable<AuditResponse>>> GetUserTrailsAsync(Guid userId)
    {
        var trails = await _context.AuditTrails.Where(a => a.UserId == userId).OrderByDescending(a => a.Id).Take(250).ToListAsync();
        var mappedLogs = trails.Adapt<IEnumerable<AuditResponse>>();
        return await Result<IEnumerable<AuditResponse>>.SuccessAsync(mappedLogs);
    }
}
