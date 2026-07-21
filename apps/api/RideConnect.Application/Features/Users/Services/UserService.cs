using RideConnect.Application.Features.Users.DTOs;
using RideConnect.Application.Features.Users.Interfaces;
using RideConnect.Application.Persistence;
using RideConnect.Domain.Common;
using RideConnect.Domain.Errors;

namespace RideConnect.Application.Features.Users.Services;

public class UserService(IUserRepository userRepository): IUserService
{
    public async Task<Result<CurrentUserResponse>> GetCurrentUserAsync(Guid userId)
    {
        var user = await userRepository.GetByIdAsync(userId);
        if (user is null)
            return Result<CurrentUserResponse>.Failure(UserErrors.UserNotFound);

        var response = new CurrentUserResponse(
            user.Id,
            user.Username,
            user.Email,
            user.FirstName,
            user.LastName,
            user.ProfilePictureUrl,
            user.Bio,
            user.CreatedAt);
        
        return Result<CurrentUserResponse>.Success(response);
    }
    
    public Task<Result<PublicUserResponse>> GetPublicUserAsync(Guid id)
    {
        throw new NotImplementedException();   
    }
    
    // public Task<Result<CurrentUserResponse>> UpdateAsync(UpdateUserRequest request)
    // {
    //     throw new NotImplementedException();   
    // }
}
