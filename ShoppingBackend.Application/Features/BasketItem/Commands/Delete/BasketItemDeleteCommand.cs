using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.BasketItem.Commands.Delete;

public class BasketItemDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
