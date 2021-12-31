using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Application.Patient.Interfaces;
using BoilerPlatte.Domain.Constants;
using BoilerPlatte.Infrastructure.Identity.Permissions;
using BoilerPlatte.Shared.DTOs.Patient;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BoilerPlatte.Host.Controllers.Patient;

public class ContactController : BaseController
{
    private readonly IContactService _service;

    public ContactController(IContactService service)
    {
        _service = service;
    }

    [HttpPost("search")]
    [MustHavePermission(PermissionConstants.Contacts.Search)]
    [SwaggerOperation(Summary = "Search Contact using available Filters.")]
    public async Task<IActionResult> SearchAsync(ContactListFilter filter)
    {
        var per = await _service.SearchAsync(filter);
        return Ok(per);
    }

    [HttpPost]
    [MustHavePermission(PermissionConstants.Contacts.Register)]
    public async Task<IActionResult> CreateAsync(CreateContactRequest request)
    {
        return Ok(await _service.CreateContactAsync(request));
    }

    [HttpPut("{id}")]
    [MustHavePermission(PermissionConstants.Contacts.Update)]
    public async Task<IActionResult> UpdateAsync(UpdateContactRequest request, Guid id)
    {
        return Ok(await _service.UpdateContactAsync(request, id));
    }

    [HttpDelete("{id}")]
    [MustHavePermission(PermissionConstants.Contacts.Remove)]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var brandId = await _service.DeleteContactAsync(id);
        return Ok(brandId);
    }

    [HttpPost("generate-random")]
    public async Task<IActionResult> GenerateRandomAsync(GenerateRandomContactRequest request)
    {
        var jobId = await _service.GenerateRandomContactAsync(request);
        return Ok(jobId);
    }

    // [HttpDelete("delete-random")]
    // public async Task<IActionResult> DeleteRandomAsync()
    // {
    //    var jobId = await _service.DeleteContactAsync();
    //    return Ok(jobId);
    // }
}
