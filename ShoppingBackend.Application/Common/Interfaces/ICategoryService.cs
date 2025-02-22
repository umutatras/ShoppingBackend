using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Application.Features.Category.Commands.Update;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface ICategoryService
{
    Task<CategoryAddResponse> CategoryAdd(CategoryAddCommand request, CancellationToken cancellationToken);
    Task<CategoryUpdateResponse> CategoryUpdate(CategoryUpdateCommand request, CancellationToken cancellationToken);
}
