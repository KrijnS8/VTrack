
// GET api/users/{user.id}
// GET api/users/me
// PUT api/users/me

using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RideConnect.API.Extensions;
using RideConnect.Application.Features.Users.Interfaces;

namespace RideConnect.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController(IUserService userService) : ControllerBase
{
    [Authorize]
    [HttpGet("me")]
    public async Task<IActionResult> GetMe()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (!Guid.TryParse(userId, out var id))
            return Unauthorized();
        
        var response = await userService.GetCurrentUserAsync(id);

        if (response.IsFailure)
            return response.ToActionResult();
        
        return Ok(response.Value);
    }
    
    // [Authorize]
    // [HttpPut("me")]
    // public Task<IActionResult> UpdateMe()
    // {
    //     // Add Request DTO
    //     
    //     var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    //     Console.WriteLine("\n\n" + userId + "\n\n");
    //     throw new NotImplementedException();
    // }
    
    [HttpGet("{userId:guid}")]
    public Task<IActionResult> GetById(Guid userId)
    {
        throw new NotImplementedException();
    }
}
