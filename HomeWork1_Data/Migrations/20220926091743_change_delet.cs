using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeWork1__Book_Data.Migrations
{
    public partial class change_delet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Isdelet",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Isdelet",
                table: "Books");
        }
    }
}
