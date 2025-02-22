using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Basket.Commands.Update;

public class BasketUpdateCommand : IRequest<ResponseDto<BasketUpdateDto>>
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
}
