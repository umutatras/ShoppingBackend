using Microsoft.AspNetCore.Identity;

namespace ShoppingBackend.Infrastructure.Identity;

public sealed class AppUserToken : IdentityUserToken<Guid>
{
}
