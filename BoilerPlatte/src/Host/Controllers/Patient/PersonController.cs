using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Application.Patient.Interfaces;
using BoilerPlatte.Domain.Constants;
using BoilerPlatte.Infrastructure.Identity.Permissions;
using BoilerPlatte.Shared.DTOs.Patient;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BoilerPlatte.Host.Controllers.Patient;

public class PersonController : BaseController
{
    private readonly IPersonService _service;

    public PersonController(IPersonService service)
    {
        _service = service;
    }

    [HttpPost("search")]
    [MustHavePermission(PermissionConstants.Persons.Search)]
    [SwaggerOperation(Summary = "Search Brands using available Filters.")]
    public async Task<IActionResult> SearchAsync(PersonListFilter filter)
    {
        var per = await _service.SearchAsync(filter);
        return Ok(per);
    }

    [HttpPost]
    [MustHavePermission(PermissionConstants.Persons.Register)]
    public async Task<IActionResult> CreateAsync(CreatePersonRequest request)
    {
        return Ok(await _service.CreatePersonAsync(request));
    }

    [HttpPut("{id}")]
    [MustHavePermission(PermissionConstants.Persons.Update)]
    public async Task<IActionResult> UpdateAsync(UpdatePersonRequest request, Guid id)
    {
        return Ok(await _service.UpdatePersonAsync(request, id));
    }

    [HttpDelete("{id}")]
    [MustHavePermission(PermissionConstants.Persons.Remove)]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var brandId = await _service.DeletePersonAsync(id);
        return Ok(brandId);
    }

    [HttpPost("generate-random")]
    public async Task<IActionResult> GenerateRandomAsync(GenerateRandomPersonRequest request)
    {
        var jobId = await _service.GenerateRandomPersonAsync(request);
        return Ok(jobId);
    }

    // [HttpDelete("delete-random")]
    // public async Task<IActionResult> DeleteRandomAsync()
    // {
    //    var jobId = await _service.DeletePersonAsync();
    //    return Ok(jobId);
    // }
}
