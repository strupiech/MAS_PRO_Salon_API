using Microsoft.EntityFrameworkCore.Migrations;

namespace MAS_PRO_Salon.Migrations
{
    public partial class Update11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ManagerPersonID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerPersonID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ManagerPersonID",
                table: "Employees",
                newName: "ManagerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Employees",
                newName: "ManagerPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerPersonID",
                table: "Employees",
                column: "ManagerPersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ManagerPersonID",
                table: "Employees",
                column: "ManagerPersonID",
                principalTable: "Employees",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
