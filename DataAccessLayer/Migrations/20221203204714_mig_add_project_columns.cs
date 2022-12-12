using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_project_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image4",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "PortFolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "PortFolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Value",
                table: "PortFolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Image4",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "PortFolios");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "PortFolios");
        }
    }
}
