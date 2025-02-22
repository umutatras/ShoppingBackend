using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Product.Query.GetAll;

public sealed record GetAllProductQuery : IRequest<ResponseDto<List<GetAllProductDto>>>
{
}
