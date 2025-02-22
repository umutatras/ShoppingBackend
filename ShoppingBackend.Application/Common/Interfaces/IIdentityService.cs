using ShoppingBackend.Application.Common.Models.Identity;
using ShoppingBackend.Application.Features.Auth.Commands.UpdateUser;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IIdentityService
{
    Task<bool> AuthenticateAsync(IdentityAuthenticateRequest request, CancellationToken cancellationToken);
    Task<IdentityLoginResponse> LoginAsync(IdentityLoginRequest request, CancellationToken cancellationToken);

    Task<bool> CheckEmailExistsAsync(string email, CancellationToken cancellationToken);
    Task<IdentityRegisterResponse> RegisterAsync(IdentityRegisterRequest request, CancellationToken cancellationToken);
    Task<bool> UpdateUserAsync(UpdateUserCommand request, CancellationToken cancellationToken);

    Task<IdentityVerifyEmailResponse> VerifyEmailAsync(IdentityVerifyEmailRequest request, CancellationToken cancellationToken);
    Task<IdentityCreateEmailTokenResponse> CreateEmailTokenAsync(IdentityCreateEmailTokenRequest request, CancellationToken cancellation);

    Task<bool> CheckIfEmailVerifiedAsync(string email, CancellationToken cancellationToken);

    Task<bool> CheckSecurityStampAsync(Guid userId, string securityStamp, CancellationToken cancellationToken);
    Task<IdentityRefreshTokenResponse> RefreshTokenAsync(IdentityRefreshTokenRequest request, CancellationToken cancellationToken);
}
