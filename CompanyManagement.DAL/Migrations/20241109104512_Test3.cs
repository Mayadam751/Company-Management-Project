using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMApplicationDbContext.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_EmployeeDepartmentId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_EmployeeDepartmentId",
                table: "Employees",
                column: "EmployeeDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_EmployeeDepartmentId",
                table: "Employees");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_EmployeeDepartmentId",
                table: "Employees",
                column: "EmployeeDepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
