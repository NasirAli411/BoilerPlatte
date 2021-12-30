using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Identity;

namespace BoilerPlatte.Application.Abstractions.Services.Identity;

public interface IIdentityService : ITransientService
{
    Task<IResult> RegisterAsync(RegisterRequest request, string origin);

    Task<IResult<string>> ConfirmEmailAsync(string userId, string code, string tenant);

    Task<IResult<string>> ConfirmPhoneNumberAsync(string userId, string code);

    Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);

    Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);

    Task<IResult> UpdateProfileAsync(UpdateProfileRequest request, string userId);
}
