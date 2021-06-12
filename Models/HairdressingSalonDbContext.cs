using System;
using MAS_PRO_Salon.Configurations;
using Microsoft.EntityFrameworkCore;

namespace MAS_PRO_Salon.Models
{
    public class HairdressingSalonDbContext : DbContext
    {
        public HairdressingSalonDbContext()
        {
        }

        public HairdressingSalonDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=localhost;Database=maspro;Username=postgres;Password=admin");
       
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeTraining> EmployeeTrainings { get; set; }
        
        public DbSet<Order> Orders { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Training> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AddressEfConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentEfConfiguration());
            modelBuilder.ApplyConfiguration(new ClientEfConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEfConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeTrainingEfConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEfConfiguration());
            modelBuilder.ApplyConfiguration(new PersonEfConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEfConfiguration());
            modelBuilder.ApplyConfiguration(new ProductOrderEfConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceEfConfiguration());
            modelBuilder.ApplyConfiguration(new TrainingEfConfiguration());

          
        }
    }
}
