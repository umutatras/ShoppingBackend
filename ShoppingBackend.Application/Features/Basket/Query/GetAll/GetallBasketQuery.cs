using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Basket.Query.GetAll;

public class GetallBasketQuery : IRequest<ResponseDto<List<GetAllBasketDto>>>
{

}
