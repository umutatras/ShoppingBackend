using ShoppingBackend.Application.Common.Models.Product;
using ShoppingBackend.Application.Features.Product.Commands.Add;
using ShoppingBackend.Application.Features.Product.Commands.Delete;
using ShoppingBackend.Application.Features.Product.Commands.Update;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IProductService
{
    Task<ProductAddResponse> ProductAdd(ProductAddCommand request, CancellationToken cancellationToken);
    Task<ProductUpdateResponse> ProductUpdate(ProductUpdateCommand request, CancellationToken cancellationToken);
    Task<bool> ProductDelete(ProductDeleteCommand request, CancellationToken cancellationToken);
    //Task<List<GetAllProductsDto>> GetAllProducts(GetAllProductsQuery query, CancellationToken cancellationToken);
}
