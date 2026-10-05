using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork01.Migrations
{
    /// <inheritdoc />
    public partial class AddCarRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EmployeeId",
                table: "Cars",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Employee_EmployeeId",
                table: "Cars",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmpId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Employee_EmployeeId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_EmployeeId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Cars");
        }
    }
}
