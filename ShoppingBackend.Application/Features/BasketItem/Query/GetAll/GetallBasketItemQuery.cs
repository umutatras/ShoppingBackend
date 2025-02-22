using MediatR;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Query.GetAll;

public class GetallBasketItemQuery : IRequest<ResponseDto<List<BasketItemGetAllDto>>>
{

}
