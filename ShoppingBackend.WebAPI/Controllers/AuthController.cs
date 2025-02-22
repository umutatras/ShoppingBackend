using ChatGPTClone.Application.Features.Auth.Commands.RefreshToken;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Auth.Commands.Login;
using ShoppingBackend.Application.Features.Auth.Commands.Register;
using ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ApiControllerBase
{
    public AuthController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("Login")]
    public async Task<IActionResult> Login(AuthLoginCommand command, CancellationToken cancellationToken)
    {
        return Ok(await Mediatr.Send(command, cancellationToken));
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register(AuthRegisterCommand command, CancellationToken cancellationToken)
    {
        return Ok(await Mediatr.Send(command, cancellationToken));
    }
    [HttpPost("update-user")]
    public async Task<IActionResult> UpdateUser(UpdateUserCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken(AuthRefreshTokenCommand command, CancellationToken cancellationToken)
  => Ok(await Mediatr.Send(command, cancellationToken));
}