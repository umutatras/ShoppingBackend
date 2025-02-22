using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Category.Query.GetAll;

public sealed record GetAllCategoriesQuery : IRequest<ResponseDto<List<GetAllCategoriesDto>>>
{

}
