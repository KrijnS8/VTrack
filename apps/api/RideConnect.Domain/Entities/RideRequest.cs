using RideConnect.Domain.Enums;

namespace RideConnect.Domain.Entities;

public class RideRequest
{
	public Guid Id { get; set; }

	public Guid CreatorId { get; set; }

	public User Creator { get; set; } = null!;

	public string Title { get; set; } = null!;

	public string? Description { get; set; }

	public RideStatus Status { get; set; }

	public string Location { get; set; } = null!;

	public int MaxParticipants { get; set; }

	public DateTimeOffset CreatedAt { get; set; }

	public DateTimeOffset UpdatedAt { get; set; }

	public DateTimeOffset StartsAt { get; set; }

	public ICollection<RideParticipant> Participants { get; set; } = [];
}
