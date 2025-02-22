using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Product.Commands.Delete;

public sealed class ProductDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
