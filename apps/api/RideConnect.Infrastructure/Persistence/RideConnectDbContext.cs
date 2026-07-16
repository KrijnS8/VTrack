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
	public DbSet<UserMotorcycle> UserMotorcycles => Set<UserMotorcycle>();
	public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
	public DbSet<RideRequest> RideRequests => Set<RideRequest>();
	public DbSet<RideParticipant> RideParticipants => Set<RideParticipant>();
}
