using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Category.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Add;

public sealed class BasketAddCommand : IRequest<ResponseDto<BasketAddDto>>
{
    public string UserId { get; set; }
}
