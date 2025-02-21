using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<RefreshToken> RefreshTokens { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    int SaveChanges();
}
