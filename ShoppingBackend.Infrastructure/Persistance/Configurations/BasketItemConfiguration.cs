﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Infrastructure.Persistance.Configurations;

public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
{
    public void Configure(EntityTypeBuilder<BasketItem> builder)
    {
        builder.HasOne(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Basket).WithMany(x => x.BasketItems).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);
    }
}
