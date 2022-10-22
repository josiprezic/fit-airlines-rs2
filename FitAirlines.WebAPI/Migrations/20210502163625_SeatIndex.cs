using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class SeatIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatColumn",
                table: "ReservedSeats");

            migrationBuilder.RenameColumn(
                name: "SeatRow",
                table: "ReservedSeats",
                newName: "SeatIndex");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatIndex",
                table: "ReservedSeats",
                newName: "SeatRow");

            migrationBuilder.AddColumn<int>(
                name: "SeatColumn",
                table: "ReservedSeats",
                nullable: false,
                defaultValue: 0);
        }
    }
}
