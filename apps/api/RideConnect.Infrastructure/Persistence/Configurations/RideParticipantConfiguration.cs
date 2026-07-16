using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence.Configurations;

public sealed class RideParticipantConfiguration
	: IEntityTypeConfiguration<RideParticipant>
{
	public void Configure(EntityTypeBuilder<RideParticipant> builder)
	{
		// Table
		builder.ToTable("RideParticipant");

		// Primary Key
		builder.HasKey(x => new { x.UserId, x.RideId });

		// Relationships
		builder.HasOne(x => x.User)
			.WithMany(x => x.RideParticipations)
			.HasForeignKey(x => x.UserId);
		
		builder.HasOne(x => x.Ride)
			.WithMany(x => x.Participants)
			.HasForeignKey(x => x.RideId);
	}
}
