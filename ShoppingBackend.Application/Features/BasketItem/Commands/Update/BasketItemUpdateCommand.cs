using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Update;

public class BasketItemUpdateCommand : IRequest<ResponseDto<BasketItemUpdateDto>>
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public int BasketId { get; set; }

    public int Quantity { get; set; }
}
