using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

namespace ShoppingBackend.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ApiControllerBase
    {
        public ProductCategoryController(ISender mediator) : base(mediator)
        {

        }
        [HttpPost("product-category-add")]
        public async Task<IActionResult> ProductCategoryAdd(ProductCategoryAddCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));

        [HttpPut("product-category-update")]
        public async Task<IActionResult> ProductCategoryUpdate(ProductCategoryUpdateCommand command, CancellationToken cancellationToken)
=> Ok(await Mediatr.Send(command, cancellationToken));
    }
}
