using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence.Configurations;

public sealed class ManufacturerConfiguration
	: IEntityTypeConfiguration<Manufacturer>
{
	public void Configure(EntityTypeBuilder<Manufacturer> builder)
	{
		// Table
		builder.ToTable("Manufacturer");

		// Primary Key
		builder.HasKey(x => x.Id);

		// Properties
		builder.Property(x => x.Name)
			.HasMaxLength(100);
		
		builder.Property(x => x.Country)
			.HasMaxLength(100);
		
		builder.Property(x => x.LogoUrl)
			.HasMaxLength(1000);

		// Indexes
		builder.HasIndex(x => x.Name)
			.IsUnique();
	}	
}
