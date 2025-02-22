using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Delete;
using ShoppingBackend.Application.Features.BasketItem.Commands.Update;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BasketItemController : ApiControllerBase
{
    public BasketItemController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("basket-item-add")]
    public async Task<IActionResult> BasketItemAdd(BasketItemAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpPut("basket-item-update")]
    public async Task<IActionResult> BasketItemUpdate(BasketItemUpdateCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpDelete("basket-item-delete")]
    public async Task<IActionResult> BasketItemDelete(BasketItemDeleteCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));
}
