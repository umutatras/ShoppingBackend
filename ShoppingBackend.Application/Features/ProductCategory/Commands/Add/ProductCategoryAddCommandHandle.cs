using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddCommandHandle : IRequestHandler<ProductCategoryAddCommand, ResponseDto<ProductCategoryAddDto>>
{
    private readonly IProductCategoryService productCategoryService;

    public ProductCategoryAddCommandHandle(IProductCategoryService productCategoryService)
    {
        this.productCategoryService = productCategoryService;
    }


    public async Task<ResponseDto<ProductCategoryAddDto>> Handle(ProductCategoryAddCommand request, CancellationToken cancellationToken)
    {
        var result = await productCategoryService.ProductCategoryAdd(request, cancellationToken);

        return new ResponseDto<ProductCategoryAddDto>(ProductCategoryAddDto.Create(result), "BasketItem Add Successfuly");

    }

}