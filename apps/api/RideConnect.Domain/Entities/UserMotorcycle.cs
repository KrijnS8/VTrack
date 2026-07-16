namespace RideConnect.Domain.Entities;

public class UserMotorcycle
{
	public Guid Id { get; set; }

	public Guid ManufacturerId { get; set; }

	public Manufacturer Manufacturer { get; set; } = null!;

	public Guid OwnerId { get; set; }

	public User Owner { get; set; } = null!;

	public string Model { get; set; } = null!;

	public string? Color { get; set; }

	public int Year { get; set; }
}
