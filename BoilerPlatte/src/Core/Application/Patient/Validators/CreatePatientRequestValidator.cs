using BoilerPlatte.Application.Common.Validators;
using BoilerPlatte.Shared.DTOs.Catalog;
using FluentValidation;

namespace BoilerPlatte.Application.Patient.Validators;

public class CreatePatientRequestValidator : CustomValidator<CreateBrandRequest>
{
    public CreatePatientRequestValidator()
    {
        RuleFor(p => p.Name).MaximumLength(75).NotEmpty();
    }
}
