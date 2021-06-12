using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class ProductOrderEfConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasKey(a => new { a.ProductID, a.OrderID });

            builder.Property(a => a.ProductID).IsRequired();

            builder.Property(a => a.OrderID).IsRequired();

            builder.Property(a => a.Amount).IsRequired();

        }
    }
}
