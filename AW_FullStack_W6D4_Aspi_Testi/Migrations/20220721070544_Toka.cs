using Microsoft.EntityFrameworkCore.Migrations;

namespace AW_FullStack_W6D4_Aspi_Testi.Migrations
{
    public partial class Toka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Source",
                table: "Topic",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Source",
                table: "Topic");
        }
    }
}
