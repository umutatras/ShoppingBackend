using Microsoft.EntityFrameworkCore;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    int SaveChanges();
}
