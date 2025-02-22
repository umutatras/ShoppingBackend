using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Features.BasketItem.Commands.Add;
using ShoppingBackend.Application.Features.BasketItem.Commands.Delete;
using ShoppingBackend.Application.Features.BasketItem.Commands.Update;
using ShoppingBackend.Application.Features.BasketItem.Query.GetAll;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IBasketItemService
{
    Task<BasketItemAddResponse> BasketItemAdd(BasketItemAddCommand request, CancellationToken cancellationToken);
    Task<BasketItemUpdateResponse> BasketItemUpdate(BasketItemUpdateCommand request, CancellationToken cancellationToken);
    Task<bool> BasketItemDelete(BasketItemDeleteCommand request, CancellationToken cancellationToken);
    Task<List<BasketItemGetAllDto>> BasketGetAll(GetallBasketItemQuery request, CancellationToken cancellationToken);
}
