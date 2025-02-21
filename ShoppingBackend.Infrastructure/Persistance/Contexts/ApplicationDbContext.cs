using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Application.Common.Interfaces;
using ShoppingBackend.Domain.Entities;
using ShoppingBackend.Infrastructure.Identity;

namespace ShoppingBackend.Infrastructure.Persistance.Contexts;

public sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>, IApplicationDbContext
{
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}