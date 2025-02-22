using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Update;

namespace ShoppingBackend.Application.Features.Product.Commands.Update;

public sealed class ProductUpdateCommandHandle : IRequestHandler<ProductUpdateCommand, ResponseDto<ProductUpdateDto>>
{
    private readonly IProductService _productService;

    public ProductUpdateCommandHandle(IProductService productService)
    {
        _productService = productService;
    }


    public async Task<ResponseDto<ProductUpdateDto>> Handle(ProductUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _productService.ProductUpdate(request, cancellationToken);

        return new ResponseDto<ProductUpdateDto>(ProductUpdateDto.Update(result), "Product Update Successfuly");

    }

}
