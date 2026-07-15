using Microsoft.EntityFrameworkCore;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence;

public class RideConnectDbContext : DbContext
{
	public RideConnectDbContext(DbContextOptions<RideConnectDbContext> options)
		: base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(RideConnectDbContext).Assembly);
		base.OnModelCreating(modelBuilder);
	}

	public DbSet<User> Users => Set<User>();
}
