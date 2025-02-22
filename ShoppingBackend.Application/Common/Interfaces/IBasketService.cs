using ShoppingBackend.Application.Common.Models.Basket;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IBasketService
{
    Task<BasketAddResponse> BasketAdd(BasketAddCommand request, CancellationToken cancellationToken);
}
