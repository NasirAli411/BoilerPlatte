using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Exceptions;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Domain.Dashboard;
using BoilerPlatte.Shared.DTOs.Code;
using Microsoft.Extensions.Localization;
using BoilerPlatte.Application.Code.Interfaces;
using BoilerPlatte.Domain.Code;

namespace BoilerPlatte.Application.Code.Services;

public class CodeService : ICodeService
{
    private readonly IStringLocalizer<CodeService> _localizer;
    private readonly IRepositoryAsync _repository;
    private readonly IJobService _jobService;

    public CodeService(IRepositoryAsync repository, IStringLocalizer<CodeService> localizer, IJobService jobService)
    {
        _repository = repository;
        _localizer = localizer;
        _jobService = jobService;
    }

    public async Task<Result<Guid>> CreateCodeAsync(CreateCodeRequest request)
    {
        bool codeId = await _repository.ExistsAsync<Codess>(a => a.ShortCode == request.ShortCode);
        if (codeId) throw new EntityAlreadyExistsException(string.Format(_localizer["codeId.alreadyexists"], request.ShortCode));
        var cd = new Codess(request.ShortCode, request.Description, request.Sequence, request.IsDefaultCode);
        cd.DomainEvents.Add(new StatsChangedEvent());
        var newCode = await _repository.CreateAsync<Codess>(cd);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(newCode);
    }

    public async Task<Result<Guid>> DeleteCodeAsync(Guid id)
    {
        var del = await _repository.RemoveByIdAsync<Domain.Code.Codess>(id);
        del.DomainEvents.Add(new StatsChangedEvent());
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }

    public async Task<Result<string>> DeleteRandomCodeAsync()
    {
        string jobId = _jobService.Schedule<ICodeGeneratorJob>(x => x.CleanAsync(), TimeSpan.FromSeconds(5));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<Result<string>> GenerateRandomCodeAsync(GenerateRandomCodeRequest request)
    {
        string jobId = _jobService.Enqueue<ICodeGeneratorJob>(x => x.GenerateAsync(request.NSeed));
        return await Result<string>.SuccessAsync(jobId);
    }

    public async Task<PaginatedResult<CodeDto>> SearchAsync(CodeListFilter filter)
    {
        return await _repository.GetSearchResultsAsync<Domain.Code.Codess, CodeDto>(filter.PageNumber, filter.PageSize, filter.OrderBy, filter.AdvancedSearch, filter.Keyword);

    }

    public async Task<Result<Guid>> UpdateCodeAsync(UpdateCodeRequest request, Guid id)
    {
        var cod = await _repository.GetByIdAsync<Domain.Code.Codess>(id);
        if (cod == null) throw new EntityNotFoundException(string.Format(_localizer["cod.notfound"], id));
        var update = cod.Updates(request.ShortCode, request.Description, request.Sequence, request.IsDefaultCode);
        update.DomainEvents.Add(new StatsChangedEvent());
        await _repository.UpdateAsync<Domain.Code.Codess>(update);
        await _repository.SaveChangesAsync();
        return await Result<Guid>.SuccessAsync(id);
    }
}
