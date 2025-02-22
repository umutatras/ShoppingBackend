using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.ProductCategory.Commands.Update;

public class ProductCategoryUpdateCommand : IRequest<ResponseDto<ProductCategoryUpdateDto>>
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
}
