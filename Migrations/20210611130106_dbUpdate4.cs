using System.Collections.Generic;
using MAS_PRO_Salon.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_PRO_Salon.Migrations
{
    public partial class dbUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonID1",
                table: "Employees",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<List<Specialization>>(
                name: "Specializations",
                table: "Employees",
                type: "integer[]",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonID1",
                table: "Employees",
                column: "PersonID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_People_PersonID1",
                table: "Employees",
                column: "PersonID1",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_People_PersonID1",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PersonID1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PersonID1",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Specializations",
                table: "Employees");
        }
    }
}
