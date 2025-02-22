using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Update;

public class BasketItemUpdateCommandHandle : IRequestHandler<BasketItemUpdateCommand, ResponseDto<BasketItemUpdateDto>>
{
    private readonly IBasketItemService _basketItemService;

    public BasketItemUpdateCommandHandle(IBasketItemService basketItemService)
    {
        _basketItemService = basketItemService;
    }


    public async Task<ResponseDto<BasketItemUpdateDto>> Handle(BasketItemUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketItemService.BasketItemUpdate(request, cancellationToken);

        return new ResponseDto<BasketItemUpdateDto>(BasketItemUpdateDto.Update(result), "BasketItem Update Successfuly");

    }

}