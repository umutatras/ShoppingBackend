using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasketItemController : ApiControllerBase
{
    public BasketItemController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("basket-item-add")]
    public async Task<IActionResult> BasketAdd(BasketItemAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));
}
