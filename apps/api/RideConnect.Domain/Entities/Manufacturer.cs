namespace RideConnect.Domain.Entities;

public class Manufacturer
{
	public Guid Id { get; set; }

	public string Name { get; set; } = null!;

	public string Country { get; set; } = null!;

	public string? LogoUrl { get; set; }
}
