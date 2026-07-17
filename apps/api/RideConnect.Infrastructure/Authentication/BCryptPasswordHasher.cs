using RideConnect.Application.Persistence;

namespace RideConnect.Infrastructure.Authentication;

public class BCryptPasswordHasher : IPasswordHasher
{
	public string Hash(string password)
	{
		return BCrypt.Net.BCrypt.HashPassword(password);
	}

	public bool Verify(string hashedPassword, string providedPassword)
	{
		return BCrypt.Net.BCrypt.Verify(providedPassword, hashedPassword);
	}
}
