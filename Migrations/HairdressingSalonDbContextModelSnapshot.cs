﻿// <auto-generated />
using System;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAS_PRO_Salon.Migrations
{
    [DbContext(typeof(HairdressingSalonDbContext))]
    partial class HairdressingSalonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MAS_PRO_Salon.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("FlatNumber")
                        .HasColumnType("integer");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int?>("AddressID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ClientID")
                        .HasColumnType("integer");

                    b.Property<int>("HairdresserID")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceID")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AppointmentID");

                    b.HasIndex("AddressID");

                    b.HasIndex("ClientID");

                    b.HasIndex("HairdresserID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.EmployeeTraining", b =>
                {
                    b.Property<int>("TrainingID")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("AccuireDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("TrainingID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmployeeTrainings");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<int?>("AddressID")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OrderID");

                    b.HasIndex("AddressID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonID");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("People");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Details")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductID")
                        .HasColumnType("integer");

                    b.Property<int>("OrderID")
                        .HasColumnType("integer");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.HasKey("ProductID", "OrderID");

                    b.HasIndex("OrderID");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Details")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Training", b =>
                {
                    b.Property<int>("TrainingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

                    b.Property<string>("Certificate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("HoursAmount")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("TrainingID");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Client", b =>
                {
                    b.HasBaseType("MAS_PRO_Salon.Models.Person");

                    b.Property<int?>("Discount")
                        .HasColumnType("integer");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Employee", b =>
                {
                    b.HasBaseType("MAS_PRO_Salon.Models.Person");

                    b.Property<int?>("AddressID")
                        .HasColumnType("integer");

                    b.Property<string>("EmployeeTypes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("HourlyRate")
                        .HasColumnType("real");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("integer");

                    b.Property<string>("Seniority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("integer");

                    b.Property<string>("Specializations")
                        .HasColumnType("text");

                    b.Property<string>("Territory")
                        .HasColumnType("text");

                    b.HasIndex("AddressID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Appointment", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("MAS_PRO_Salon.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_PRO_Salon.Models.Employee", "Hairdresser")
                        .WithMany()
                        .HasForeignKey("HairdresserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_PRO_Salon.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Client");

                    b.Navigation("Hairdresser");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.EmployeeTraining", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_PRO_Salon.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Training");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Order", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("MAS_PRO_Salon.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.ProductOrder", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_PRO_Salon.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Client", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("MAS_PRO_Salon.Models.Client", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Employee", b =>
                {
                    b.HasOne("MAS_PRO_Salon.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.HasOne("MAS_PRO_Salon.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("MAS_PRO_Salon.Models.Employee", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_PRO_Salon.Models.Service", null)
                        .WithMany("Hairdressers")
                        .HasForeignKey("ServiceID");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("MAS_PRO_Salon.Models.Service", b =>
                {
                    b.Navigation("Hairdressers");
                });
#pragma warning restore 612, 618
        }
    }
}
