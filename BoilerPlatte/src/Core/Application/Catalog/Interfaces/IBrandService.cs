using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Catalog;

namespace BoilerPlatte.Application.Catalog.Interfaces;

public interface IBrandService : ITransientService
{
    Task<PaginatedResult<BrandDto>> SearchAsync(BrandListFilter filter);

    Task<Result<Guid>> CreateBrandAsync(CreateBrandRequest request);

    Task<Result<Guid>> UpdateBrandAsync(UpdateBrandRequest request, Guid id);

    Task<Result<Guid>> DeleteBrandAsync(Guid id);

    Task<Result<string>> GenerateRandomBrandAsync(GenerateRandomBrandRequest request);

    Task<Result<string>> DeleteRandomBrandAsync();
}
