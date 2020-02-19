using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloCore.Migrations
{
    public partial class KlantID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Klant",
                newName: "KlantID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KlantID",
                table: "Klant",
                newName: "Id");
        }
    }
}
