using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Catalog.Validators;

public class CreateBrandRequestValidator : CustomValidator<CreateBrandRequest>
{
    public CreateBrandRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
