using System;
using System.Collections.Generic;
using System.Linq;
using MAS_PRO_Salon.Helpers;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAS_PRO_Salon.Configurations
{
    public class EmployeeEfConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var valueComparer = new ValueComparer<ICollection<string>>(
                    (c1, c2) => c1.SequenceEqual(c2),
                    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    c => (ICollection<string>)c.ToHashSet());

            builder.Property(a => a.HourlyRate).IsRequired();

            builder.Property(a => a.Seniority).IsRequired();

            builder.Property(a => a.Seniority)
                .HasConversion(
                    v => v.ToString(),
                    v => (Seniority)Enum.Parse(typeof(Seniority), v));

            builder.Property(a => a.EmployeeTypes).IsRequired();

            var converterEm = new EnumCollectionJsonValueConverter<EmployeeType>();
            var comparerEm = new CollectionValueComparer<EmployeeType>();

            builder.Property(e => e.EmployeeTypes)
              .HasConversion(converterEm)
              .Metadata.SetValueComparer(comparerEm);

            var converterSp = new EnumCollectionJsonValueConverter<Specialization>();
            var comparerSp = new CollectionValueComparer<Specialization>();

            builder.Property(e => e.Specializations)
              .HasConversion(converterSp)
              .Metadata.SetValueComparer(comparerSp);
        }
    }
}
