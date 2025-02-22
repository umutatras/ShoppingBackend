using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Delete;

public class BasketItemDeleteCommandHandle : IRequestHandler<BasketItemDeleteCommand, ResponseDto<bool>>
{
    private readonly IBasketItemService _basketItemService;

    public BasketItemDeleteCommandHandle(IBasketItemService basketItemService)
    {
        _basketItemService = basketItemService;
    }


    public async Task<ResponseDto<bool>> Handle(BasketItemDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketItemService.BasketItemDelete(request, cancellationToken);

        return new ResponseDto<bool>(result, "BasketItem Deleted Successfuly");

    }

}