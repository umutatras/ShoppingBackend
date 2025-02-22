using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

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
    }
}
