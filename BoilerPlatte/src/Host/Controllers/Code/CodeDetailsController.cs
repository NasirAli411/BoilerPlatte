using BoilerPlatte.Application.Code.Interfaces;
using BoilerPlatte.Domain.Constants;
using BoilerPlatte.Infrastructure.Identity.Permissions;
using BoilerPlatte.Shared.DTOs.Code;
using Microsoft.AspNetCore.Mvc;

namespace BoilerPlatte.Host.Controllers.Code;

public class CodeDetailsController : BaseController
{
    private readonly ICodeDetailsService _service;

    public CodeDetailsController(ICodeDetailsService service)
    {
        _service = service;
    }

    [HttpPost("search")]
    [MustHavePermission(PermissionConstants.CodeDetails.Search)]
    public async Task<IActionResult> SearchAsync(CodeDetailsListFilter filter)
    {
        var cds = await _service.SearchAsync(filter);
        return Ok(cds);
    }

    [HttpPost]
    [MustHavePermission(PermissionConstants.CodeDetails.Register)]
    public async Task<IActionResult> CreateAsync(CreateCodeDetailsRequest request)
    {
        return Ok(await _service.CreateCodeDetailsAsync(request));
    }

    [HttpPut("{id}")]
    [MustHavePermission(PermissionConstants.CodeDetails.Update)]
    public async Task<IActionResult> UpdateAsync(UpdateCodeDetailsRequest request, Guid id)
    {
        return Ok(await _service.UpdateCodeDetailsAsync(request, id));
    }

    [HttpDelete("{id}")]
    [MustHavePermission(PermissionConstants.CodeDetails.Remove)]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var cdId = await _service.DeleteCodeDetailsAsync(id);
        return Ok(cdId);
    }
}
