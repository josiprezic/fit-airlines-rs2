using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class Users_RemoveUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UQ__Users__536C85E455F25E7B",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Users",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__536C85E455F25E7B",
                table: "Users",
                column: "Username",
                unique: true);
        }
    }
}
