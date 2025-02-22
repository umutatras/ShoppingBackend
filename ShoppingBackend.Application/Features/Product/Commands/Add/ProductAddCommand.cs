using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Product.Commands.Add;

public sealed class ProductAddCommand : IRequest<ResponseDto<ProductAddDto>>
{
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }
}
