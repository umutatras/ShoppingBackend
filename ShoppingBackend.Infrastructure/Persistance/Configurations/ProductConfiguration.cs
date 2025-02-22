using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingBackend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBackend.Infrastructure.Persistance.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasMany(x => x.ProductCategories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Restrict);
    }
}
