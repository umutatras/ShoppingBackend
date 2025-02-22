using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Basket.Commands.Delete;

public class BasketDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
