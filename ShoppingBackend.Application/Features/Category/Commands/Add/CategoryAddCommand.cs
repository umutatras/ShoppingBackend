using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Category.Commands.Add;

public sealed class CategoryAddCommand : IRequest<ResponseDto<CategoryAddDto>>
{
    public string Name { get; set; } = null!;
}
