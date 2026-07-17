using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RideConnect.API.Controllers;

[ApiController]
[Route("api/ride-requests")]
public class RideRequestsController : ControllerBase
{
    [Authorize]
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
