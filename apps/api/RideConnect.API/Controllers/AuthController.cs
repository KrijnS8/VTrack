using Microsoft.AspNetCore.Mvc;
using RideConnect.API.Extensions;
using RideConnect.Application.Features.Authentication.Interfaces;
using RideConnect.Application.Features.Authentication.DTOs;

namespace RideConnect.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authService) : ControllerBase
{
    private readonly IAuthService _authService = authService;
    
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var response = await _authService.RegisterAsync(request);

        if (response.IsFailure)
            return response.ToActionResult();
        
        return Ok(response.Value);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var response = await _authService.LoginAsync(request);
        
        if (response.IsFailure)
            return response.ToActionResult();
        
        return Ok(response.Value);
    }
}
