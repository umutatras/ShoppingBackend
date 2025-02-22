using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Add;

public class BasketItemAddCommand : IRequest<ResponseDto<BasketItemAddDto>>
{
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
}
