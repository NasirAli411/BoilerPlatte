using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Code.Validators;

public class UpdateCodeRequestValidator : CustomValidator<UpdateBrandRequest>
{
    public UpdateCodeRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
