using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class PersonEfConfiguration : IEntityTypeConfiguration<Person>
    {

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(a => a.PersonID);

            //builder.Property(a => a.PersonID).UseIdentityAlwaysColumn();

            builder.Property(a => a.FirstName).IsRequired();

            builder.Property(a => a.LastName).IsRequired();

            builder.Property(a => a.PhoneNumber).IsRequired();

            builder.HasIndex(e => e.PhoneNumber).IsUnique();

            builder.HasIndex(a => a.PhoneNumber).IsUnique();

            builder.Property(a => a.Email).IsRequired();
        }
    }
}
