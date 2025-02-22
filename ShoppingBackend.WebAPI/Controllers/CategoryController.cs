using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;
using ShoppingBackend.Application.Features.Category.Commands.Add;

namespace ShoppingBackend.WebAPI.Controllers;

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

}
