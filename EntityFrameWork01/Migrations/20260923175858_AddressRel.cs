using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork01.Migrations
{
    /// <inheritdoc />
    public partial class AddressRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress_City",
                schema: "edu",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress_Country",
                schema: "edu",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress_Street",
                schema: "edu",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress_Country",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentAddress_Street",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipmentCity",
                table: "Customer",
                type: "varchar(30)",
                maxLength: 30,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentAddress_City",
                schema: "edu",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ShipmentAddress_Country",
                schema: "edu",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ShipmentAddress_Street",
                schema: "edu",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ShipmentAddress_Country",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ShipmentAddress_Street",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ShipmentCity",
                table: "Customer");
        }
    }
}
