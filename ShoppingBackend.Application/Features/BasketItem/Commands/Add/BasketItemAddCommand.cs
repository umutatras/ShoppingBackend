using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Add;

public class BasketItemAddCommand : IRequest<ResponseDto<BasketItemAddDto>>
{
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
}
