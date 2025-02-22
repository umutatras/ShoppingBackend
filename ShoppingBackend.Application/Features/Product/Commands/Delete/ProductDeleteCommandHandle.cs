using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Product.Commands.Delete;

public sealed class ProductDeleteCommandHandle : IRequestHandler<ProductDeleteCommand, ResponseDto<bool>>
{
    private readonly IProductService _productService;

    public ProductDeleteCommandHandle(IProductService productService)
    {
        _productService = productService;
    }


    public async Task<ResponseDto<bool>> Handle(ProductDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await _productService.ProductDelete(request, cancellationToken);

        return new ResponseDto<bool>(result, "Product Deleted Successfuly");

    }

}