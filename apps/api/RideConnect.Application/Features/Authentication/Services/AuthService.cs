using RideConnect.Application.Features.Authentication.DTOs;
using RideConnect.Application.Features.Authentication.Interfaces;
using RideConnect.Application.Persistence;

namespace RideConnect.Application.Features.Authentication.Services;

public sealed class AuthService(IUserRepository userRepository) : IAuthService
{
    private readonly IUserRepository _userRepository = userRepository;
    
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
