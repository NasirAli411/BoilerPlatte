using BoilerPlatte.Application.Catalog.Interfaces;
using BoilerPlatte.Domain.Constants;
using BoilerPlatte.Infrastructure.Identity.Permissions;
using BoilerPlatte.Shared.DTOs.Catalog;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BoilerPlatte.Host.Controllers.Catalog;

public class BrandController : BaseController
{
    private readonly IBrandService _service;

    public BrandController(IBrandService service)
    {
        _service = service;
    }

    [HttpPost("search")]
    [MustHavePermission(PermissionConstants.Brands.Search)]
    [SwaggerOperation(Summary = "Search Brands using available Filters.")]
    public async Task<IActionResult> SearchAsync(BrandListFilter filter)
    {
        var brands = await _service.SearchAsync(filter);
        return Ok(brands);
    }

    [HttpPost]
    [MustHavePermission(PermissionConstants.Brands.Register)]
    public async Task<IActionResult> CreateAsync(CreateBrandRequest request)
    {
        return Ok(await _service.CreateBrandAsync(request));
    }

    [HttpPut("{id}")]
    [MustHavePermission(PermissionConstants.Brands.Update)]
    public async Task<IActionResult> UpdateAsync(UpdateBrandRequest request, Guid id)
    {
        return Ok(await _service.UpdateBrandAsync(request, id));
    }

    [HttpDelete("{id}")]
    [MustHavePermission(PermissionConstants.Brands.Remove)]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var brandId = await _service.DeleteBrandAsync(id);
        return Ok(brandId);
    }

    [HttpPost("generate-random")]
    public async Task<IActionResult> GenerateRandomAsync(GenerateRandomBrandRequest request)
    {
        var jobId = await _service.GenerateRandomBrandAsync(request);
        return Ok(jobId);
    }

    [HttpDelete("delete-random")]
    public async Task<IActionResult> DeleteRandomAsync()
    {
        var jobId = await _service.DeleteRandomBrandAsync();
        return Ok(jobId);
    }
}
