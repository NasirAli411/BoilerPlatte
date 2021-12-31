using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Exceptions;
using BoilerPlatte.Application.Patient.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Domain.Catalog;
using BoilerPlatte.Domain.Dashboard;
using BoilerPlatte.Domain.Code;
using BoilerPlatte.Shared.DTOs.Code;
using Microsoft.Extensions.Localization;
using BoilerPlatte.Application.Code.Interfaces;

namespace BoilerPlatte.Application.Patient.Services;

public class CodeDetailsService : ICodeDetailsService
{
    private readonly IStringLocalizer<CodeDetailsService> _localizer;
    private readonly IRepositoryAsync _repository;
    private readonly IJobService _jobService;

    public CodeDetailsService(IRepositoryAsync repository, IStringLocalizer<CodeDetailsService> localizer, IJobService jobService)
    {
        _repository = repository;
        _localizer = localizer;
        _jobService = jobService;
    }

    public async Task<Result<Guid>> CreateCodeDetailsAsync(CreateCodeDetailsRequest request)
    {
        bool codeId = await _repository.ExistsAsync<CodeDetails>(a => a.CodeDetailId == request.CodeDetailId);
        if (codeId) throw new EntityAlreadyExistsException(string.Format(_localizer["CodeDetailId.alreadyexists"], request.CodeDetailId));
        var codeDetails = new CodeDetails(request.Description, request.CodeValue1, request.CodeValue2, request.CodeValue3, request.Sequence, request.IsDefaultCode);
        codeDetails.DomainEvents.Add(new StatsChangedEvent());
        var newCodeDetails = await _repository.CreateAsync<CodeDetails>(codeDetails);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(newCodeDetails);
    }

    public async Task<Result<Guid>> DeleteCodeDetailsAsync(Guid id)
    {
        var del = await _repository.RemoveByIdAsync<Domain.Code.Codess>(id);
        del.DomainEvents.Add(new StatsChangedEvent());
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }

    public async Task<Result<string>> DeleteRandomCodeDetailsAsync()
    {
        string jobId = _jobService.Schedule<ICodeGeneratorJob>(x => x.CleanAsync(), TimeSpan.FromSeconds(5));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<Result<string>> GenerateRandomCodeDetailsAsync(GenerateRandomCodeDetailsRequest request)
    {
        string jobId = _jobService.Enqueue<ICodeGeneratorJob>(x => x.GenerateAsync(request.NSeed));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<PaginatedResult<CodeDetailsDto>> SearchAsync(CodeDetailsListFilter filter)
    {
        return await _repository.GetSearchResultsAsync<Domain.Code.Codess, CodeDetailsDto>(filter.PageNumber, filter.PageSize, filter.OrderBy, filter.AdvancedSearch, filter.Keyword);
    }

    public async Task<Result<Guid>> UpdateCodeDetailsAsync(UpdateCodeDetailsRequest request, Guid id)
    {
        var cod = await _repository.GetByIdAsync<Domain.Code.CodeDetails>(id);
        if (cod == null) throw new EntityNotFoundException(string.Format(_localizer["cod.notfound"], id));
        var update = cod.Update(request.Description, request.CodeValue1, request.CodeValue2, request.CodeValue3);
        update.DomainEvents.Add(new StatsChangedEvent());
        await _repository.UpdateAsync<Domain.Code.CodeDetails>(update);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }
}
