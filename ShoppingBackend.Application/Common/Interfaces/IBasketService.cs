using ShoppingBackend.Application.Common.Models.Basket;
using ShoppingBackend.Application.Features.Basket.Commands.Add;
using ShoppingBackend.Application.Features.Basket.Commands.Delete;
using ShoppingBackend.Application.Features.Basket.Commands.Update;
using ShoppingBackend.Application.Features.Basket.Query.GetAll;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IBasketService
{
    Task<BasketAddResponse> BasketAdd(BasketAddCommand request, CancellationToken cancellationToken);
    Task<BasketUpdateResponse> BasketUpdate(BasketUpdateCommand request, CancellationToken cancellationToken);
    Task<bool> BasketDelete(BasketDeleteCommand request, CancellationToken cancellationToken);
    Task<List<GetAllBasketDto>> GetAllBasket(GetallBasketQuery request, CancellationToken cancellationToken);
}
