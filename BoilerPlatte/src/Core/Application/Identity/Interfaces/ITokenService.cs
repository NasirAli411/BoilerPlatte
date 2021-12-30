using BoilerPlatte.Application.Common.Interfaces;
using BoilerPlatte.Application.Wrapper;
using BoilerPlatte.Shared.DTOs.Identity;

namespace BoilerPlatte.Application.Abstractions.Services.Identity;

public interface ITokenService : ITransientService
{
    Task<IResult<TokenResponse>> GetTokenAsync(TokenRequest request, string ipAddress);

    Task<IResult<TokenResponse>> RefreshTokenAsync(RefreshTokenRequest request, string ipAddress);
}
