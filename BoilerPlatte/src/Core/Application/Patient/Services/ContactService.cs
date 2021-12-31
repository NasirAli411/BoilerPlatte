using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Exceptions;
using BoilerPlatte.Application.Patient.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Domain.Catalog;
using BoilerPlatte.Domain.Dashboard;
using BoilerPlatte.Domain.Patient;
using BoilerPlatte.Shared.DTOs.Catalog;
using BoilerPlatte.Shared.DTOs.Patient;
using Microsoft.Extensions.Localization;

namespace BoilerPlatte.Application.Patient.Services;

public class ContactService : IContactService
{
    private readonly IStringLocalizer<ContactService> _localizer;
    private readonly IRepositoryAsync _repository;
    private readonly IJobService _jobService;

    public ContactService(IRepositoryAsync repository, IStringLocalizer<ContactService> localizer, IJobService jobService)
    {
        _repository = repository;
        _localizer = localizer;
        _jobService = jobService;
    }

    public async Task<Result<Guid>> CreateContactAsync(CreateContactRequest request)
    {
        bool contactExists = await _repository.ExistsAsync<Contact>(a => a.Type == request.Type);
        if (contactExists) throw new EntityAlreadyExistsException(string.Format(_localizer["contact.alreadyexists"], request.Type));
        var contact = new Contact(request.Type, request.PrimaryContact, request.Address1, request.Address2, request.Address3, request.PostCode, request.City, request.PostalCode, request.State, request.Phone1, request.Phone2);
        contact.DomainEvents.Add(new StatsChangedEvent());
        var newContact = await _repository.CreateAsync<Contact>(contact);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(newContact);
    }

    public async Task<Result<Guid>> DeleteContactAsync(Guid id)
    {
        var del = await _repository.RemoveByIdAsync<Domain.Patient.Contact>(id);
        del.DomainEvents.Add(new StatsChangedEvent());
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }

    public async Task<Result<string>> DeleteRandomContactAsync()
    {
        string jobId = _jobService.Schedule<IContactGeneratorJob>(x => x.CleanAsync(), TimeSpan.FromSeconds(5));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<Result<string>> GenerateRandomContactAsync(GenerateRandomContactRequest request)
    {
        string jobId = _jobService.Enqueue<IContactGeneratorJob>(x => x.GenerateAsync(request.NSeed));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<PaginatedResult<ContactDto>> SearchAsync(ContactListFilter filter)
    {
        return await _repository.GetSearchResultsAsync<Domain.Patient.Contact, ContactDto>(filter.PageNumber, filter.PageSize, filter.OrderBy, filter.AdvancedSearch, filter.Keyword);

    }

    public async Task<Result<Guid>> UpdateContactAsync(UpdateContactRequest request, Guid id)
    {
        var per = await _repository.GetByIdAsync<Domain.Patient.Contact>(id);
        if (per == null) throw new EntityNotFoundException(string.Format(_localizer["per.notfound"], id));
        var update = per.Update(request.Type, request.PrimaryContact, request.Address1, request.Address2, request.Address3, request.PostalCode, request.City, request.State, request.PostCode, request.Phone1, request.Phone2);
        update.DomainEvents.Add(new StatsChangedEvent());
        await _repository.UpdateAsync<Domain.Patient.Contact>(update);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }
}
