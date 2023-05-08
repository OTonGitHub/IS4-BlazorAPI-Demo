using IdentityModel.Client;

namespace BlazorClient.Services;

public interface ITokenService
{
    Task<TokenResponse> GetToken(string scope);
}
