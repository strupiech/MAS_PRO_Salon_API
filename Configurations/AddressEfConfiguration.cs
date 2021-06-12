using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class AddressEfConfiguration : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.AddressID);

            builder.Property(a => a.AddressID).UseIdentityAlwaysColumn();

            builder.Property(a => a.City).IsRequired();

            builder.Property(a => a.Street).IsRequired();

            builder.Property(a => a.StreetNumber).IsRequired();

            builder.Property(a => a.PostalCode).IsRequired();
        }
    }
}
