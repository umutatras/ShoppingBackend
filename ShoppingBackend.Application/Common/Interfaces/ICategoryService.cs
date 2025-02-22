using ShoppingBackend.Application.Common.Models.Category;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using ShoppingBackend.Application.Features.Category.Commands.Delete;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using ShoppingBackend.Application.Features.Category.Query.GetAll;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface ICategoryService
{
    Task<CategoryAddResponse> CategoryAdd(CategoryAddCommand request, CancellationToken cancellationToken);
    Task<CategoryUpdateResponse> CategoryUpdate(CategoryUpdateCommand request, CancellationToken cancellationToken);
    Task<bool> CategoryDelete(CategoryDeleteCommand request, CancellationToken cancellationToken);
    Task<List<GetAllCategoriesDto>> GetAllCategories(GetAllCategoriesQuery query, CancellationToken cancellationToken);
}
