using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Basket.Commands.Add;

public sealed class BasketAddCommand : IRequest<ResponseDto<BasketAddDto>>
{
    public string UserId { get; set; }
}
