using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using ShoppingBackend.Application.Features.Product.Commands.Delete;
using ShoppingBackend.Application.Features.Product.Commands.Update;

namespace ShoppingBackend.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ApiControllerBase
{
    public ProductController(ISender mediator) : base(mediator)
    {

    }
    [HttpPost("product-add")]
    public async Task<IActionResult> ProductAdd(ProductAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpPut("product-update")]
    public async Task<IActionResult> ProductUpdate(ProductUpdateCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

    [HttpDelete("product-delete")]
    public async Task<IActionResult> ProductDelete(ProductDeleteCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));
}
