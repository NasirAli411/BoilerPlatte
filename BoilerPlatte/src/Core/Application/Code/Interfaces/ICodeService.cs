using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Code;

namespace BoilerPlatte.Application.Code.Interfaces;

public interface ICodeService : ITransientService
{
    Task<PaginatedResult<CodeDto>> SearchAsync(CodeListFilter filter);

    Task<Result<Guid>> CreateCodeAsync(CreateCodeRequest request);

    Task<Result<Guid>> UpdateCodeAsync(UpdateCodeRequest request, Guid id);

    Task<Result<Guid>> DeleteCodeAsync(Guid id);

    Task<Result<string>> GenerateRandomCodeAsync(GenerateRandomCodeRequest request);

    Task<Result<string>> DeleteRandomCodeAsync();
}
