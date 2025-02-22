using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Features.Basket.Commands.Delete;

public class BasketDeleteCommand:IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
