using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Update;

public class BasketUpdateCommand:IRequest<ResponseDto<BasketUpdateDto>>
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
}
