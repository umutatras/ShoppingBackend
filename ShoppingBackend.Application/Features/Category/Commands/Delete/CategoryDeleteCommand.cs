using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Category.Commands.Delete;

public sealed class CategoryDeleteCommand : IRequest<ResponseDto<bool>>
{
    public int Id { get; set; }
}
