
// GET api/users/{user.id}
// GET api/users/me
// PUT api/users/me

using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RideConnect.API.Extensions;
using RideConnect.Application.Features.Users.DTOs;
using RideConnect.Application.Features.Users.Interfaces;

namespace RideConnect.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(IUserService userService) : ControllerBase
{
    // Get Current User Profile
    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetMe()
    {
        if (!User.TryGetUserId(out var userId))
            return Unauthorized();
        
        var response = await userService.GetCurrentUserAsync(userId);

        if (response.IsFailure)
            return response.ToActionResult();
        
        return Ok(response.Value);
    }

    // Update User Password
    [Authorize]
    [HttpPut("me/password")]
    public Task<IActionResult> UpdatePassword(UpdatePasswordRequest request)
    {
        throw new NotImplementedException(); 
    }

    // Update User Email
    [Authorize]
    [HttpPut("me/email")]
    public Task<IActionResult> UpdateEmail(UpdateEmailRequest request)
    {
        throw new NotImplementedException();
    }

    // Update User Profile
    [Authorize]
    [HttpPut("me")]
    public Task<IActionResult> UpdateMe(UpdateUserRequest request)
    {
        throw new NotImplementedException();  
    }
    
    // Get User Profile
    [HttpGet("{userId:guid}")]
    public Task<IActionResult> GetById(Guid userId)
    {
        throw new NotImplementedException();
    }
}
