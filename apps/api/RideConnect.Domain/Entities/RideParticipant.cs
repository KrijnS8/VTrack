using RideConnect.Domain.Enums;

namespace RideConnect.Domain.Entities;

public class RideParticipant
{
	public Guid UserId { get; set; }

	public User User { get; set; } = null!;

	public Guid RideId { get; set; }

	public RideRequest Ride { get; set; } = null!;

	public RideRole Role {get; set; }

	public DateTimeOffset JoinedAt {get; set; }
}
