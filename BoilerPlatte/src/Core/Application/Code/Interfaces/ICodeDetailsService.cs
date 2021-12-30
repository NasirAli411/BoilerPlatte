using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Code;

namespace BoilerPlatte.Application.Code.Interfaces;

public interface ICodeDetailsService : ITransientService
{
    Task<PaginatedResult<CodeDetailsDto>> SearchAsync(CodeDetailsListFilter filter);

    Task<Result<Guid>> CreateCodeDetailsAsync(CreateCodeDetailsRequest request);

    Task<Result<Guid>> UpdateCodeDetailsAsync(UpdateCodeDetailsRequest request, Guid id);

    Task<Result<Guid>> DeleteCodeDetailsAsync(Guid id);

    Task<Result<string>> GenerateRandomCodeDetailsAsync(GenerateRandomCodeDetailsRequest request);

    Task<Result<string>> DeleteRandomCodeDetailsAsync();
}
