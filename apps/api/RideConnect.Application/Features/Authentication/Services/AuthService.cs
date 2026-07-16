using RideConnect.Application.Features.Authentication.DTOs;
using RideConnect.Application.Features.Authentication.Interfaces;

namespace RideConnect.Application.Features.Authentication.Services;

public sealed class AuthService : IAuthService
{
    public Task<AuthResponse> RegisterAsync(RegisterRequest request)
    {
        return Task.FromResult(new AuthResponse
        {
            AccessToken = "TODO",
            ExpiresAt = DateTimeOffset.Now.AddHours(1)
        });
    }
    
    public Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }
}
