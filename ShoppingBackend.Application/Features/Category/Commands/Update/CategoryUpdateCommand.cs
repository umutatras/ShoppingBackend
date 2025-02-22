using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Category.Commands.Update;

public sealed class CategoryUpdateCommand : IRequest<ResponseDto<CategoryUpdateDto>>
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
