using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using ShoppingBackend.Application.Features.Basket.Commands.Update;
using ShoppingBackend.Application.Features.Product.Commands.Add;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasketController : ApiControllerBase
{
    public BasketController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("basket-add")]
    public async Task<IActionResult> BasketAdd(BasketAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpPut("basket-update")]
    public async Task<IActionResult> BasketUpdate(BasketUpdateCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));
}
