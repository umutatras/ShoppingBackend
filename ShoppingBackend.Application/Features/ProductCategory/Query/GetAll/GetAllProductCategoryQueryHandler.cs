using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Query.GetAll;

public class GetAllProductCategoryQueryHandler : IRequestHandler<GetAllProductCategoryQuery, ResponseDto<List<GetAllProductCategoryDto>>>
{
    private readonly IProductCategoryService _productCategoryService;
    public GetAllProductCategoryQueryHandler(IProductCategoryService productCategoryService)
    {
        _productCategoryService = productCategoryService;
    }

    public async Task<ResponseDto<List<GetAllProductCategoryDto>>> Handle(GetAllProductCategoryQuery request, CancellationToken cancellationToken)
    {
        var result = await _productCategoryService.ProductCategoryGetAll(request, cancellationToken);
        return new ResponseDto<List<GetAllProductCategoryDto>> { Data = result, Success = true, Message = string.Empty, Errors = null };
    }
}