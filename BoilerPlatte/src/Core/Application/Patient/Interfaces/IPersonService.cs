using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Patient;

namespace BoilerPlatte.Application.Patient.Interfaces;

public interface IPersonService : ITransientService
{
    Task<PaginatedResult<PersonDto>> SearchAsync(PersonListFilter filter);

    Task<Result<Guid>> CreatePersonAsync(CreatePersonRequest request);

    Task<Result<Guid>> UpdatePersonAsync(UpdatePersonRequest request, Guid id);

    Task<Result<Guid>> DeletePersonAsync(Guid id);

    Task<Result<string>> GenerateRandomPersonAsync(GenerateRandomPersonRequest request);

    Task<Result<string>> DeleteRandomPersonAsync();
}
