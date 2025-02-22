using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;

namespace ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

public sealed class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseDto<bool>>
{
    private readonly IIdentityService _identityService;

    public UpdateUserCommandHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    public async Task<ResponseDto<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var response = await _identityService.UpdateUserAsync(request, cancellationToken);
        return new ResponseDto<bool>(response, "User Register Successfuly");
    }
}