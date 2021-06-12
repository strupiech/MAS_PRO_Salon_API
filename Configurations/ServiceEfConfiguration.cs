using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class ServiceEfConfiguration : IEntityTypeConfiguration<Service>
    {

        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(a => a.ServiceID);

            builder.Property(a => a.ServiceID).UseIdentityAlwaysColumn();

            builder.Property(a => a.Name).IsRequired();

            builder.Property(a => a.Duration).IsRequired();

            builder.Property(a => a.Price).IsRequired();
        }
    }
}
