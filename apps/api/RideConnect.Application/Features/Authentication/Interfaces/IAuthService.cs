using RideConnect.Application.Features.Authentication.DTOs;
using RideConnect.Domain.Common;

namespace RideConnect.Application.Features.Authentication.Interfaces;

public interface IAuthService
{
    Task<Result<AuthResponse>> RegisterAsync(RegisterRequest request);
    
    Task<Result<AuthResponse>> LoginAsync(LoginRequest request);
}
