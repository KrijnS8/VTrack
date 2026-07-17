namespace RideConnect.Application.Features.Authentication.DTOs;

public class AuthResponse
{
    public string AccessToken { get; init; } = string.Empty;
    
    public DateTimeOffset ExpiresAt { get; init; }
    
    public string? RefreshToken { get; init; } = string.Empty;
}
