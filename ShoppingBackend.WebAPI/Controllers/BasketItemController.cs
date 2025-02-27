﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Delete;
using ShoppingBackend.Application.Features.BasketItem.Commands.Update;
using ShoppingBackend.Application.Features.BasketItem.Query.GetAll;

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

    [HttpGet("basket-item-getall")]
    public async Task<IActionResult> BasketItemGetAll([FromQuery] GetallBasketItemQuery query, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(query, cancellationToken));
}
