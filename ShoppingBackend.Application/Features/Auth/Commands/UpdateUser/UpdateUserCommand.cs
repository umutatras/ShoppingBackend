using MediatR;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

public sealed class UpdateUserCommand : IRequest<ResponseDto<bool>>
{
    public Guid UserId { get; set; }
    public string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

}
