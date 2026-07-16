using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RideConnect.Domain.Entities;

namespace RideConnect.Infrastructure.Persistence.Configurations;

public sealed class UserConfiguration: IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
        // Table
        builder.ToTable("User", table =>
        {
            table.HasCheckConstraint(
                "CK_User_Username_Length",
                "length(\"Username\") >= 3");
        });

        // Primary Key
        builder.HasKey(x => x.Id);

        // Properties
        builder.Property(x => x.Username)
            .HasMaxLength(50);

        builder.Property(x => x.Email)
            .HasMaxLength(255);

        builder.Property(x => x.FirstName)
            .HasMaxLength(50);

        builder.Property(x => x.LastName)
            .HasMaxLength(50);
        
        // Indexes
        builder.HasIndex(x => x.Username)
            .IsUnique();
        
        builder.HasIndex(x => x.Email)
            .IsUnique();
	}
}
