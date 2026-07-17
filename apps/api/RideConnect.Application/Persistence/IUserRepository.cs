using RideConnect.Domain.Entities;

namespace RideConnect.Application.Persistence;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    
    Task<User?> GetByEmailAsync(string email);
    
    Task<User?> GetByUsernameAsync(string username);
    
    Task AddAsync(User user);
    
    Task SaveChangesAsync();
}
