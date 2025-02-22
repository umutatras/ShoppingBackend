using ShoppingBackend.Application.Common.Models.ProductCategory;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Add;
using ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IProductCategoryService
{
    Task<ProductCategoryAddResponse> ProductCategoryAdd(ProductCategoryAddCommand request, CancellationToken cancellationToken);
    Task<ProductCategoryUpdateResponse> ProductCategoryUpdate(ProductCategoryUpdateCommand request, CancellationToken cancellationToken);
}
