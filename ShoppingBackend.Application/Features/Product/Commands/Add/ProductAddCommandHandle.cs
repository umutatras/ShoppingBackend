using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Product.Commands.Add;

public sealed class ProductAddCommandHandle : IRequestHandler<ProductAddCommand, ResponseDto<ProductAddDto>>
{
    private readonly IProductService _productService;

    public ProductAddCommandHandle(IProductService productService)
    {
        _productService = productService;
    }


    public async Task<ResponseDto<ProductAddDto>> Handle(ProductAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _productService.ProductAdd(request, cancellationToken);

        return new ResponseDto<ProductAddDto>(ProductAddDto.Create(result), "Product Add Successfuly");

    }

}