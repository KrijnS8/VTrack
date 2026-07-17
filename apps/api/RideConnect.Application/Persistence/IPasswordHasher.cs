namespace RideConnect.Application.Persistence;

public interface IPasswordHasher
{
    string Hash(string password);
    
    bool Verify(string hashedPassword, string providedPassword);
}
