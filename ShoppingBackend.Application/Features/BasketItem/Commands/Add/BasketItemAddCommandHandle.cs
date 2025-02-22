using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Add;

public class BasketItemAddCommandHandle : IRequestHandler<BasketItemAddCommand, ResponseDto<BasketItemAddDto>>
{
    private readonly IBasketItemService _basketItemService;

    public BasketItemAddCommandHandle(IBasketItemService basketItemService)
    {
        _basketItemService = basketItemService;
    }


    public async Task<ResponseDto<BasketItemAddDto>> Handle(BasketItemAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketItemService.BasketItemAdd(request, cancellationToken);

        return new ResponseDto<BasketItemAddDto>(BasketItemAddDto.Create(result), "BasketItem Add Successfuly");

    }

}