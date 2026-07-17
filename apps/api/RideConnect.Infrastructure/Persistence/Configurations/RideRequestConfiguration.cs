using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence.Configurations;

public sealed class RideRequestConfiguration
	: IEntityTypeConfiguration<RideRequest>
{
	public void Configure(EntityTypeBuilder<RideRequest> builder)
	{
		// Table
		builder.ToTable("RideRequest", table =>
		{
			// Constraints
			table.HasCheckConstraint(
				"CK_RideRequest_MaxParticipants",
				"\"MaxParticipants\" > 1");
		});

		// Primary Key
		builder.HasKey(x => x.Id);

		// Properties
		builder.Property(x => x.Title)
			.HasMaxLength(100);

		builder.Property(x => x.Description)
			.HasMaxLength(1000);
		
		builder.Property(x => x.Location)
			.HasMaxLength(255);
		
		// Relationships
		builder.HasOne(x => x.Creator)
			.WithMany(x => x.CreatedRideRequests)
			.HasForeignKey(x => x.CreatorId);
	}
}