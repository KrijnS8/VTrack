using RideConnect.Domain.Common;
using RideConnect.Domain.Entities;

namespace RideConnect.Application.Persistence;

public interface IJwtTokenGenerator
{
    JwtToken Generate(User user);
    
    public record JwtToken(string AccessToken, DateTimeOffset ExpiresAt);
}
