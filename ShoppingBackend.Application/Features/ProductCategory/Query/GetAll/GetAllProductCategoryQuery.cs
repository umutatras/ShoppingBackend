using MediatR;
using ShoppingBackend.Application.Common.Models.BasketItem;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Query.GetAll;

public class GetAllProductCategoryQuery : IRequest<ResponseDto<List<GetAllProductCategoryDto>>>
{

}
