using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Delete;

public class ProductCategoryAddCommandHandle : IRequestHandler<ProductCategoryDeleteCommand, ResponseDto<bool>>
{
    private readonly IProductCategoryService productCategoryService;

    public ProductCategoryAddCommandHandle(IProductCategoryService productCategoryService)
    {
        this.productCategoryService = productCategoryService;
    }


    public async Task<ResponseDto<bool>> Handle(ProductCategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await productCategoryService.ProductCategoryDelete(request, cancellationToken);

        return new ResponseDto<bool>(result, "BasketItem Remove Successfuly");

    }

}