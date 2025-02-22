﻿using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Add;

public sealed class BasketAddCommandHandle : IRequestHandler<BasketAddCommand, ResponseDto<BasketAddDto>>
{
    private readonly IBasketService _basketService;

    public BasketAddCommandHandle(IBasketService basketService)
    {
        _basketService = basketService;
    }


    public async Task<ResponseDto<BasketAddDto>> Handle(BasketAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketService.BasketAdd(request, cancellationToken);

        return new ResponseDto<BasketAddDto>(BasketAddDto.Create(result), "Category Add Successfuly");

    }

}