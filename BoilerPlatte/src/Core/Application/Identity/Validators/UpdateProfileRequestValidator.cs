using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Application.Storage;
using BoilerPlatte.Shared.DTOs.Identity;
using FluentValidation;

namespace BoilerPlatte.Application.Validators.Identity;

public class UpdateProfileRequestValidator : CustomValidator<UpdateProfileRequest>
{
    public UpdateProfileRequestValidator()
    {
        RuleFor(p => p.FirstName).MaximumLength(75).NotEmpty();
        RuleFor(p => p.LastName).MaximumLength(75).NotEmpty();
        RuleFor(p => p.Email).NotEmpty();
        RuleFor(p => p.Image).SetValidator(new FileUploadRequestValidator());
    }
}
