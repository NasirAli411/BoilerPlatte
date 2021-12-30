using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Auditing;

namespace BoilerPlatte.Application.Auditing;

public interface IAuditService : ITransientService
{
    Task<IResult<IEnumerable<AuditResponse>>> GetUserTrailsAsync(Guid userId);
}
