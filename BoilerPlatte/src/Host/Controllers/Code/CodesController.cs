using BoilerPlatte.Application.Code.Interfaces;
using BoilerPlatte.Domain.Constants;
using BoilerPlatte.Infrastructure.Identity.Permissions;
using BoilerPlatte.Shared.DTOs.Code;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BoilerPlatte.Host.Controllers.Code;

public class CodesController : BaseController
{
    private readonly ICodeService _service;

    public CodesController(ICodeService service)
    {
        _service = service;
    }

    [HttpPost("search")]
    [MustHavePermission(PermissionConstants.Code.Search)]
    [SwaggerOperation(Summary = "Search Code using available Filters.")]
    public async Task<IActionResult> SearchAsync(CodeListFilter filter)
    {
        var brands = await _service.SearchAsync(filter);
        return Ok(brands);
    }

    [HttpPost]
    [MustHavePermission(PermissionConstants.Code.Register)]
    public async Task<IActionResult> CreateAsync(CreateCodeRequest request)
    {
        return Ok(await _service.CreateCodeAsync(request));
    }

    [HttpPut("{id}")]
    [MustHavePermission(PermissionConstants.Code.Update)]
    public async Task<IActionResult> UpdateAsync(UpdateCodeRequest request, Guid id)
    {
        return Ok(await _service.UpdateCodeAsync(request, id));
    }

    [HttpDelete("{id}")]
    [MustHavePermission(PermissionConstants.Code.Remove)]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var brandId = await _service.DeleteCodeAsync(id);
        return Ok(brandId);
    }

    [HttpPost("generate-random")]
    public async Task<IActionResult> GenerateRandomAsync(GenerateRandomCodeRequest request)
    {
        var jobId = await _service.GenerateRandomCodeAsync(request);
        return Ok(jobId);
    }

    [HttpDelete("delete-random")]
    public async Task<IActionResult> DeleteRandomAsync()
    {
        var jobId = await _service.DeleteRandomCodeAsync();
        return Ok(jobId);
    }
}
