﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Application.Features.Category.Commands.Update;

namespace ShoppingBackend.WebAPI.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class CategoryController : ApiControllerBase
{
    public CategoryController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("category-add")]
    public async Task<IActionResult> CategoryAdd(CategoryAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpPost("category-update")]
    public async Task<IActionResult> CategoryUpdate(CategoryUpdateCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

}
