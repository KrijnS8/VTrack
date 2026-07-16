using Microsoft.EntityFrameworkCore;
using RideConnect.Application.Persistence;
using RideConnect.Domain.Entities;
using RideConnect.Infrastructure.Persistence;

namespace RideConnect.Infrastructure.Repositories;

public sealed class UserRepository(RideConnectDbContext dbContext) : IUserRepository
{
    private readonly RideConnectDbContext _dbContext = dbContext;

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<User?> GetByEmailAsync(string email)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == email);
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(x => x.Username == username);
    }

    public async Task AddAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
