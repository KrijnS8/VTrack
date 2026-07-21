using RideConnect.Application.Features.Users.DTOs;
using RideConnect.Domain.Common;

namespace RideConnect.Application.Features.Users.Interfaces;

public interface IUserService
{
    Task<Result<CurrentUserResponse>> GetCurrentUserAsync(Guid userId);
    
    Task<Result<PublicUserResponse>> GetPublicUserAsync(Guid id);
    
    // Task<Result<CurrentUserResponse>> UpdateAsync(UpdateUserRequest request);
}
