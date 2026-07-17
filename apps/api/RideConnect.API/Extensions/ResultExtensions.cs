using Microsoft.AspNetCore.Mvc;
using RideConnect.Domain.Common;
using RideConnect.Domain.Errors;

namespace RideConnect.API.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToActionResult<T>(
        this Result<T> result)
    {
        if (result.IsSuccess)
            return new OkObjectResult(result.Value);

        return result.Error.Type switch
        {
            ErrorType.Validation => new BadRequestObjectResult(result.Error),
            ErrorType.Conflict => new ConflictObjectResult(result.Error),
            ErrorType.NotFound => new NotFoundObjectResult(result.Error),
            ErrorType.Authentication => new UnauthorizedObjectResult(result.Error),
            ErrorType.Authorization => new ObjectResult(result.Error)
            {
                StatusCode = StatusCodes.Status403Forbidden
            },
            _ => throw new InvalidOperationException(
                $"Unhandled error type: {result.Error.Type}.")
        };
    }
}
