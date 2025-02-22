using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Persistance.Configurations;

public class BasketConfiguration : IEntityTypeConfiguration<Basket>
{
    public void Configure(EntityTypeBuilder<Basket> builder)
    {
        builder.HasMany(x=>x.BasketItems).WithOne(x=>x.Basket).HasForeignKey(x => x.BasketId).OnDelete(DeleteBehavior.Restrict);  
    }
}
