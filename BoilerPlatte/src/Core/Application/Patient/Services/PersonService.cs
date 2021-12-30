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

public class PersonService : IPersonService
{
    private readonly IStringLocalizer<PersonService> _localizer;
    private readonly IRepositoryAsync _repository;
    private readonly IJobService _jobService;

    public PersonService(IRepositoryAsync repository, IStringLocalizer<PersonService> localizer, IJobService jobService)
    {
        _repository = repository;
        _localizer = localizer;
        _jobService = jobService;
    }

    public async Task<Result<Guid>> CreatePersonAsync(CreatePersonRequest request)
    {
        bool personExists = await _repository.ExistsAsync<Person>(a => a.FullName == request.FullName);
        if (personExists) throw new EntityAlreadyExistsException(string.Format(_localizer["person.alreadyexists"], request.FullName));
        var person = new Person(request.FullName, request.MrnNo, request.IDTypeCode, request.IdNo, request.Address1, request.Address2, request.CountryCode, request.PostalCode, request.PostalCodeOther, request.City, request.State, request.StateCode, request.Phone1, request.Phone2, request.Email, request.BirthDate, request.GenderCode, request.RaceCode, request.ReligionCode, request.MaritalStatusCode, request.NationalityCode, request.Image, request.PatientMergeStatus, request.PatientMergedWithPatientId);
        person.DomainEvents.Add(new StatsChangedEvent());
        var newperson = await _repository.CreateAsync<Person>(person);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(newperson);
    }

    public async Task<Result<Guid>> DeletePersonAsync(Guid id)
    {
        var del = await _repository.RemoveByIdAsync<Domain.Patient.Person>(id);
        del.DomainEvents.Add(new StatsChangedEvent());
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }

    public async Task<Result<string>> DeleteRandomPersonAsync()
    {
        string jobId = _jobService.Schedule<IPersonGeneratorJob>(x => x.CleanAsync(), TimeSpan.FromSeconds(5));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<Result<string>> GenerateRandomPersonAsync(GenerateRandomPersonRequest request)
    {
        string jobId = _jobService.Enqueue<IPersonGeneratorJob>(x => x.GenerateAsync(request.NSeed));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<PaginatedResult<PersonDto>> SearchAsync(PersonListFilter filter)
    {
        return await _repository.GetSearchResultsAsync<Domain.Patient.Person, PersonDto>(filter.PageNumber, filter.PageSize, filter.OrderBy, filter.AdvancedSearch, filter.Keyword);

    }

    public async Task<Result<Guid>> UpdatePersonAsync(UpdatePersonRequest request, Guid id)
    {
        var per = await _repository.GetByIdAsync<Domain.Patient.Person>(id);
        if (per == null) throw new EntityNotFoundException(string.Format(_localizer["per.notfound"], id));
        var update = per.Update(request.FullName, request.MrnNo, request.IDTypeCode, request.IdNo, request.Address1, request.Address2, request.CountryCode, request.PostalCode, request.PostalCodeOther, request.City, request.State, request.StateCode, request.Phone1, request.Phone2, request.Email, request.BirthDate, request.GenderCode, request.RaceCode, request.ReligionCode, request.MaritalStatusCode, request.NationalityCode, request.Image, request.PatientMergeStatus, request.PatientMergedWithPatientId);
        update.DomainEvents.Add(new StatsChangedEvent());
        await _repository.UpdateAsync<Domain.Patient.Person>(update);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }
}
