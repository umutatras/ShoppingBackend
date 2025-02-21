using ShoppingBackend.Application.Common.Models.Jwt;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IJwtService
{
    JwtGenerateTokenResponse GenerateToken(JwtGenerateTokenRequest request);
    bool ValidateToken(string token);

    Guid GetUserIdFromJwt(string token);
}