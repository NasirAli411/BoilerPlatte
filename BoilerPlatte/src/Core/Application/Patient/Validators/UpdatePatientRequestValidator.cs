using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Patient.Validators;

public class UpdatePatientRequestValidator : CustomValidator<UpdateBrandRequest>
{
    public UpdatePatientRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
