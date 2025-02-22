using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

public class ProductCategoryUpdateCommandHandle : IRequestHandler<ProductCategoryUpdateCommand, ResponseDto<ProductCategoryUpdateDto>>
{
    private readonly IProductCategoryService productCategoryService;

    public ProductCategoryUpdateCommandHandle(IProductCategoryService productCategoryService)
    {
        this.productCategoryService = productCategoryService;
    }


    public async Task<ResponseDto<ProductCategoryUpdateDto>> Handle(ProductCategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await productCategoryService.ProductCategoryUpdate(request, cancellationToken);

        return new ResponseDto<ProductCategoryUpdateDto>(ProductCategoryUpdateDto.Update(result), "BasketItem Update Successfuly");

    }

}