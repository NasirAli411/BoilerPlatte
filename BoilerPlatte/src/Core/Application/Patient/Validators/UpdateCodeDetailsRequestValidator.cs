using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Application.Storage;
using BoilerPlatte.Shared.DTOs.Code;
using FluentValidation;

namespace BoilerPlatte.Application.Code.Validators;

public class UpdateCodeDetailsRequestValidator : CustomValidator<UpdateCodeDetailsRequest>
{
    public UpdateCodeDetailsRequestValidator()
    {
        // RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
        // RuleFor(p => p.Rate).GreaterThanOrEqualTo(1).NotEqual(0);
        // RuleFor(p => p.Image).SetValidator(new FileUploadRequestValidator());
        // RuleFor(p => p.BrandId).NotEmpty().NotNull();
    }
}
