using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Catalog.Validators;

public class UpdateBrandRequestValidator : CustomValidator<UpdateBrandRequest>
{
    public UpdateBrandRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
