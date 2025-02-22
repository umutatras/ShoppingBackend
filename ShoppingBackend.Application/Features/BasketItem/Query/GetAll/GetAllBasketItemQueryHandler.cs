using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Query.GetAll;

public class GetAllBasketItemQueryHandler : IRequestHandler<GetallBasketItemQuery, ResponseDto<List<BasketItemGetAllDto>>>
{
    private readonly IBasketItemService _basketItemService;
    public GetAllBasketItemQueryHandler(IBasketItemService basketItemService)
    {
        _basketItemService = basketItemService;
    }

    public async Task<ResponseDto<List<BasketItemGetAllDto>>> Handle(GetallBasketItemQuery request, CancellationToken cancellationToken)
    {
        var result = await _basketItemService.BasketGetAll(request, cancellationToken);
        return new ResponseDto<List<BasketItemGetAllDto>> { Data = result, Success = true, Message = string.Empty, Errors = null };
    }
}