using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Basket.Query.GetAll;

public class GetAllBasketQueryHandler : IRequestHandler<GetallBasketQuery, ResponseDto<List<GetAllBasketDto>>>
{
    private readonly IBasketService _basketService;
    public GetAllBasketQueryHandler(IBasketService basketService)
    {
        _basketService = basketService;
    }

    public async Task<ResponseDto<List<GetAllBasketDto>>> Handle(GetallBasketQuery request, CancellationToken cancellationToken)
    {
        var result = await _basketService.GetAllBasket(request, cancellationToken);
        return new ResponseDto<List<GetAllBasketDto>> { Data = result, Success = true, Message = string.Empty, Errors = null };
    }
}