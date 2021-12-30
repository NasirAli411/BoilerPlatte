using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Code.Validators;

public class CreateCodeRequestValidator : CustomValidator<CreateBrandRequest>
{
    public CreateCodeRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
