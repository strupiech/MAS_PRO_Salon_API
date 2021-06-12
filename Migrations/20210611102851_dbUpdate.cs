using System;
using System.Collections.Generic;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MAS_PRO_Salon.Migrations
{
    public partial class dbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_People_ClientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_People_HairdresserID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_People_EmployeeID",
                table: "EmployeeTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_People_EmployeeID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Address_AddressID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_People_ManagerPersonID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Services_ServiceID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_AddressID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ManagerPersonID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ServiceID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "People");

            migrationBuilder.DropColumn(
                name: "EmployeeTypes",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HourlyRate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ManagerPersonID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Seniority",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ServiceID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Territory",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    Discount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Clients_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    HourlyRate = table.Column<float>(type: "real", nullable: false),
                    Seniority = table.Column<int>(type: "integer", nullable: false),
                    EmployeeTypes = table.Column<List<EmployeeType>>(type: "integer[]", nullable: false),
                    AddressID = table.Column<int>(type: "integer", nullable: true),
                    Territory = table.Column<string>(type: "text", nullable: true),
                    ManagerPersonID = table.Column<int>(type: "integer", nullable: true),
                    ServiceID = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Employees_Address_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerPersonID",
                        column: x => x.ManagerPersonID,
                        principalTable: "Employees",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_People_PersonID",
                        column: x => x.PersonID,
                        principalTable: "People",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressID",
                table: "Employees",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerPersonID",
                table: "Employees",
                column: "ManagerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ServiceID",
                table: "Employees",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Clients_ClientID",
                table: "Appointments",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Employees_HairdresserID",
                table: "Appointments",
                column: "HairdresserID",
                principalTable: "Employees",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_Employees_EmployeeID",
                table: "EmployeeTrainings",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeeID",
                table: "Orders",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clients_ClientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Employees_HairdresserID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainings_Employees_EmployeeID",
                table: "EmployeeTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeeID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "People",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "People",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "People",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int[]>(
                name: "EmployeeTypes",
                table: "People",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "HourlyRate",
                table: "People",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerPersonID",
                table: "People",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seniority",
                table: "People",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceID",
                table: "People",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Territory",
                table: "People",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_AddressID",
                table: "People",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_People_ManagerPersonID",
                table: "People",
                column: "ManagerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_People_ServiceID",
                table: "People",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_People_ClientID",
                table: "Appointments",
                column: "ClientID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_People_HairdresserID",
                table: "Appointments",
                column: "HairdresserID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainings_People_EmployeeID",
                table: "EmployeeTrainings",
                column: "EmployeeID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_People_EmployeeID",
                table: "Orders",
                column: "EmployeeID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Address_AddressID",
                table: "People",
                column: "AddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_ManagerPersonID",
                table: "People",
                column: "ManagerPersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Services_ServiceID",
                table: "People",
                column: "ServiceID",
                principalTable: "Services",
                principalColumn: "ServiceID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
