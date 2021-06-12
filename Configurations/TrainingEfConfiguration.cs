using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class TrainingEfConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasKey(a => a.TrainingID);

            builder.Property(a => a.TrainingID).UseIdentityAlwaysColumn();

            builder.Property(a => a.HoursAmount).IsRequired();

            builder.Property(a => a.Price).IsRequired();

            builder.Property(a => a.Certificate).IsRequired();

        }
    }
}
