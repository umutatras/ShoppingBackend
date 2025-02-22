using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Update;

public class BasketUpdateCommandHandle : IRequestHandler<BasketUpdateCommand, ResponseDto<BasketUpdateDto>>
{
    private readonly IBasketService _basketService;

    public BasketUpdateCommandHandle(IBasketService basketService)
    {
        _basketService = basketService;
    }


    public async Task<ResponseDto<BasketUpdateDto>> Handle(BasketUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketService.BasketUpdate(request, cancellationToken);

        return new ResponseDto<BasketUpdateDto>(BasketUpdateDto.Update(result), "Category Update Successfuly");

    }

}