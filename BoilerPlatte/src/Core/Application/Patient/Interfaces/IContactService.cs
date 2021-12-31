using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Patient;

namespace BoilerPlatte.Application.Patient.Interfaces;

public interface IContactService : ITransientService
{
    Task<PaginatedResult<ContactDto>> SearchAsync(ContactListFilter filter);

    Task<Result<Guid>> CreateContactAsync(CreateContactRequest request);

    Task<Result<Guid>> UpdateContactAsync(UpdateContactRequest request, Guid id);

    Task<Result<Guid>> DeleteContactAsync(Guid id);

    Task<Result<string>> GenerateRandomContactAsync(GenerateRandomContactRequest request);

    Task<Result<string>> DeleteRandomContactAsync();
}
