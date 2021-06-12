using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class EmployeeTrainingEfConfiguration : IEntityTypeConfiguration<EmployeeTraining>
    {
        public void Configure(EntityTypeBuilder<EmployeeTraining> builder)
        {
            builder.HasKey(a => new { a.TrainingID, a.EmployeeID });

            builder.Property(a => a.TrainingID).IsRequired();

            builder.Property(a => a.EmployeeID).IsRequired();

            builder.Property(a => a.AccuireDate).IsRequired();

        }
    }
}
