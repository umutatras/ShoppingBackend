﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingBackend.Domain.Entities;

namespace ShoppingBackend.Infrastructure.Persistance.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            // Id
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            // Token
            builder.Property(x => x.Token)
                .IsRequired()
                .HasMaxLength(100);

            // Token Index
            builder
                .HasIndex(x => x.Token)
                .IsUnique();

            // AppUserId, Token
            builder.HasIndex(x => new { x.AppUserId, x.Token });

            // Expires
            builder.Property(x => x.Expires)
                .IsRequired();



            // SecurityStamp
            builder.Property(x => x.SecurityStamp)
                .IsRequired()
                .HasMaxLength(50);

            // CreatedOn
            builder.Property(p => p.CreatedOn)
                .IsRequired();

            // CreatedByUserId
            builder.Property(p => p.CreatedByUserId)
                .IsRequired()
                .HasMaxLength(150);

            // ModifiedOn
            builder.Property(p => p.ModifiedOn)
                .IsRequired(false);

            // ModifiedByUserId
            builder.Property(p => p.ModifiedByUserId)
                .IsRequired(false)
                .HasMaxLength(150);

            builder.ToTable("RefreshTokens");
        }
    }
}
