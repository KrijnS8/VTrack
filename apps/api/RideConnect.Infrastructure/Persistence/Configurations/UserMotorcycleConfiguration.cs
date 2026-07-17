using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence.Configurations;

public sealed class UserMotorcycleConfiguration: IEntityTypeConfiguration<UserMotorcycle>
{
	public void Configure(EntityTypeBuilder<UserMotorcycle> builder)
	{
		// Table
		builder.ToTable("UserMotorcycle", table =>
		{
			// Constraints
			table.HasCheckConstraint(
				"CK_UserMotorcycle_Year",
				"\"Year\" BETWEEN 1900 AND 2100");
		});

		// Primary Key
		builder.HasKey(x => x.Id);

		// Properties
		builder.Property(x => x.Model)
			.HasMaxLength(100);
		
		builder.Property(x => x.Color)
			.HasMaxLength(30);

		// Relationships
		builder.HasOne(x => x.Manufacturer)
			.WithMany()	//.WithMany(x => x.UserMotorcycles)
			.HasForeignKey(x => x.ManufacturerId);
		
		builder.HasOne(x => x.Owner)
			.WithMany(x => x.UserMotorcycles)
			.HasForeignKey(x => x.OwnerId);
	}
}
