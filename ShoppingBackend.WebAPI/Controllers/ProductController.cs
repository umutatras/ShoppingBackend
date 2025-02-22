using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using ShoppingBackend.Application.Features.Product.Commands.Delete;
using ShoppingBackend.Application.Features.Product.Commands.Update;
using ShoppingBackend.Application.Features.Product.Query.GetAll;

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

    [HttpGet("product-getall")]
    public async Task<IActionResult> ProductGetAll([FromQuery] GetAllProductQuery query, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(query, cancellationToken));
}
