using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class ProductEfConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.ProductID);

            builder.Property(a => a.ProductID).UseIdentityAlwaysColumn();

            builder.Property(a => a.Name).IsRequired();

            builder.Property(a => a.Price).IsRequired();

        }
    }
}
