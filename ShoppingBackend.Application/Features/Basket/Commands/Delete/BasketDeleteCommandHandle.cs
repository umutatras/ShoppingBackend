using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Delete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Delete;

public class BasketDeleteCommandHandle : IRequestHandler<BasketDeleteCommand, ResponseDto<bool>>
{
    private readonly IBasketService _basketService;

    public BasketDeleteCommandHandle(IBasketService basketService)
    {
        _basketService = basketService;
    }


    public async Task<ResponseDto<bool>> Handle(BasketDeleteCommand request, CancellationToken cancellationToken)
    {
        var result = await _basketService.BasketDelete(request, cancellationToken);

        return new ResponseDto<bool>(result, "Basket Deleted Successfuly");

    }

}