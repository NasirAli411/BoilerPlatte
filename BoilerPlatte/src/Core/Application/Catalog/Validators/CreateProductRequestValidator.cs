using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Application.Storage;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Catalog.Validators;

public class CreateProductRequestValidator : CustomValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
        RuleFor(p => p.Rate).GreaterThanOrEqualTo(1).NotEqual(0);
        RuleFor(p => p.Image).SetValidator(new FileUploadRequestValidator());
        RuleFor(p => p.BrandId).NotEmpty().NotNull();
    }
}
