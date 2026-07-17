using RideConnect.Domain.Entities;

namespace RideConnect.Application.Features.Authentication.Interfaces;

public interface IJwtTokenGenerator
{
    JwtToken Generate(User user);
    
    public record JwtToken(string AccessToken, DateTimeOffset ExpiresAt);
}
