namespace RideConnect.Application.Features.Authentication.Interfaces;

public interface IPasswordHasher
{
    string Hash(string password);
    
    bool Verify(string hashedPassword, string providedPassword);
}
