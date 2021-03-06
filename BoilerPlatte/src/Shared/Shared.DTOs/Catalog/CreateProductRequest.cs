using BoilerPlatte.Shared.DTOs.Storage;

namespace BoilerPlatte.Shared.DTOs.Catalog;

public class CreateProductRequest : IMustBeValid
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Rate { get; set; }
    public Guid BrandId { get; set; }
    public FileUploadRequest Image { get; set; }
}
