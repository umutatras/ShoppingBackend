using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Product.Commands.Add;

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
}
