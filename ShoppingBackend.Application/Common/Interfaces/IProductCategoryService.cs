using ShoppingBackend.Application.Common.Models.ProductCategory;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Delete;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Update;
using ShoppingBackend.Application.Features.ProductCategory.Query.GetAll;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IProductCategoryService
{
    Task<ProductCategoryAddResponse> ProductCategoryAdd(ProductCategoryAddCommand request, CancellationToken cancellationToken);
    Task<ProductCategoryUpdateResponse> ProductCategoryUpdate(ProductCategoryUpdateCommand request, CancellationToken cancellationToken);
    Task<bool> ProductCategoryDelete(ProductCategoryDeleteCommand request, CancellationToken cancellationToken);
    Task<List<GetAllProductCategoryDto>> ProductCategoryGetAll(GetAllProductCategoryQuery request, CancellationToken cancellationToken);
}
