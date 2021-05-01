using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class fligtsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__ReservedS__Fligh__6383C8BA",
                table: "ReservedSeats");

            migrationBuilder.DropColumn(
                name: "FlightID",
                table: "ReservedSeats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlightID",
                table: "ReservedSeats",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK__ReservedS__Fligh__6383C8BA",
                table: "ReservedSeats",
                column: "FlightID",
                principalTable: "Flights",
                principalColumn: "FlightID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
