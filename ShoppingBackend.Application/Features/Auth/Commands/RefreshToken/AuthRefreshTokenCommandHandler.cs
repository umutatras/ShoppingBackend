using ChatGPTClone.Application.Features.Auth.Commands.RefreshToken;
using MediatR;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Application.Common.Models.General;
using ShoppingBackend.Application.Common.Models.Identity;

namespace ShoppingBackend.Application.Features.Auth.Commands.RefreshToken
{
    public sealed class AuthRefreshTokenCommandHandler : IRequestHandler<AuthRefreshTokenCommand, ResponseDto<AuthRefreshTokenResponse>>
    {
        private readonly IIdentityService _identityService;

        public AuthRefreshTokenCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<ResponseDto<AuthRefreshTokenResponse>> Handle(AuthRefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var identityRefreshTokenRequest = new IdentityRefreshTokenRequest(request.AccessToken, request.RefreshToken);

            var identityRefreshTokenResponse = await _identityService.RefreshTokenAsync(identityRefreshTokenRequest, cancellationToken);

            return new ResponseDto<AuthRefreshTokenResponse>(new AuthRefreshTokenResponse(identityRefreshTokenResponse.AccessToken, identityRefreshTokenResponse.Expires), "Token refreshed successfully");
        }
    }
}
