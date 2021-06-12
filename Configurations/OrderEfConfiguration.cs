using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class OrderEfConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(a => a.OrderID);

            builder.Property(a => a.OrderID).UseIdentityAlwaysColumn();

            builder.Property(a => a.Type).IsRequired();

            builder.Property(a => a.EmployeeID).IsRequired();
        }
    }
}
