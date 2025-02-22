using MediatR;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Features.Product.Commands.Add;

namespace ShoppingBackend.Application.Features.Product.Commands.Update;

public sealed class ProductUpdateCommand : IRequest<ResponseDto<ProductUpdateDto>>
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public int StockAmount { get; set; }
}
