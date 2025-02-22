using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Add;

public class ProductCategoryAddCommand : IRequest<ResponseDto<ProductCategoryAddDto>>
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
}
