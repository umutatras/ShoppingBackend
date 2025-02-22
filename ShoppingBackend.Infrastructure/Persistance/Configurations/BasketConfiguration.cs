using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Infrastructure.Persistance.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasMany(x => x.BasketItems).WithOne(x => x.Basket).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);
    }
}
