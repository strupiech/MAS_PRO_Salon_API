using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class AppointmentEfConfiguration : IEntityTypeConfiguration<Appointment>
    {

        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.AppointmentID);

            builder.Property(a => a.AppointmentID).UseIdentityAlwaysColumn();

            builder.Property(a => a.ServiceID).IsRequired();

            builder.Property(a => a.ClientID).IsRequired();

            builder.Property(a => a.AppointmentDate).IsRequired();

            builder.Property(a => a.HairdresserID).IsRequired();

            builder.Property(a => a.Status).IsRequired();

            builder.Property(a => a.Status)
                .HasConversion(
                    v => v.ToString(),
                    v => (Status)Enum.Parse(typeof(Status), v));

        }
    }
}
