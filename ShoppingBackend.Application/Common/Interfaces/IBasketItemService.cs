using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IBasketItemService
{
    Task<BasketItemAddResponse> BasketItemAdd(BasketItemAddCommand request, CancellationToken cancellationToken);
    Task<BasketItemUpdateResponse> BasketItemUpdate(BasketItemUpdateCommand request, CancellationToken cancellationToken);
}
