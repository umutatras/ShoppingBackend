using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Delete;

public class ProductCategoryDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
