using RideConnect.Application.Features.Authentication.DTOs;

namespace RideConnect.Application.Features.Authentication.Interfaces;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterRequest request);
    
    Task<AuthResponse> LoginAsync(LoginRequest request);
}
