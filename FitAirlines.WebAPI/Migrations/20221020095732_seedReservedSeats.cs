using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedReservedSeats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReservedSeats",
                columns: new[] { "ReservedSeatID", "Direction", "ReservationID", "SeatIndex", "SeatPrice" },
                values: new object[,]
                {
                    { 1, " 1", 1, 34, 0.0 },
                    { 64, " 2", 32, 56, 0.0 },
                    { 63, " 1", 32, 61, 0.0 },
                    { 62, " 2", 31, 12, 0.0 },
                    { 61, " 1", 31, 18, 0.0 },
                    { 60, " 2", 30, 7, 0.0 },
                    { 59, " 1", 30, 82, 0.0 },
                    { 58, " 2", 29, 60, 0.0 },
                    { 57, " 1", 29, 22, 0.0 },
                    { 65, " 1", 33, 72, 0.0 },
                    { 56, " 2", 28, 5, 0.0 },
                    { 54, " 2", 27, 19, 0.0 },
                    { 53, " 1", 27, 44, 0.0 },
                    { 52, " 2", 26, 11, 0.0 },
                    { 51, " 1", 26, 14, 0.0 },
                    { 50, " 2", 25, 20, 0.0 },
                    { 49, " 1", 25, 72, 0.0 },
                    { 48, " 2", 24, 66, 0.0 },
                    { 47, " 1", 24, 22, 0.0 },
                    { 55, " 1", 28, 3, 0.0 },
                    { 46, " 2", 23, 21, 0.0 },
                    { 66, " 2", 33, 65, 0.0 },
                    { 68, " 2", 34, 51, 0.0 },
                    { 86, " 2", 43, 52, 0.0 },
                    { 85, " 1", 43, 59, 0.0 },
                    { 84, " 2", 42, 61, 0.0 },
                    { 83, " 1", 42, 34, 0.0 },
                    { 82, " 2", 41, 25, 0.0 },
                    { 81, " 1", 41, 38, 0.0 },
                    { 80, " 2", 40, 4, 0.0 },
                    { 79, " 1", 40, 55, 0.0 },
                    { 67, " 1", 34, 50, 0.0 },
                    { 78, " 2", 39, 44, 0.0 },
                    { 76, " 2", 38, 2, 0.0 },
                    { 75, " 1", 38, 17, 0.0 },
                    { 74, " 2", 37, 13, 0.0 },
                    { 73, " 1", 37, 78, 0.0 },
                    { 72, " 2", 36, 38, 0.0 },
                    { 71, " 1", 36, 54, 0.0 },
                    { 70, " 2", 35, 6, 0.0 },
                    { 69, " 1", 35, 19, 0.0 },
                    { 77, " 1", 39, 45, 0.0 },
                    { 45, " 1", 23, 75, 0.0 },
                    { 44, " 2", 22, 9, 0.0 },
                    { 43, " 1", 22, 27, 0.0 },
                    { 19, " 1", 10, 60, 0.0 },
                    { 18, " 2", 9, 78, 0.0 },
                    { 17, " 1", 9, 59, 0.0 },
                    { 16, " 2", 8, 75, 0.0 },
                    { 15, " 1", 8, 6, 0.0 },
                    { 14, " 2", 7, 64, 0.0 },
                    { 13, " 1", 7, 23, 0.0 },
                    { 12, " 2", 6, 52, 0.0 },
                    { 20, " 2", 10, 4, 0.0 },
                    { 11, " 1", 6, 72, 0.0 },
                    { 9, " 1", 5, 22, 0.0 },
                    { 8, " 2", 4, 17, 0.0 },
                    { 7, " 1", 4, 41, 0.0 },
                    { 6, " 2", 3, 54, 0.0 },
                    { 5, " 1", 3, 17, 0.0 },
                    { 4, " 2", 2, 61, 0.0 },
                    { 3, " 1", 2, 22, 0.0 },
                    { 2, " 2", 1, 71, 0.0 },
                    { 10, " 2", 5, 51, 0.0 },
                    { 21, " 1", 11, 8, 0.0 },
                    { 22, " 2", 11, 80, 0.0 },
                    { 23, " 1", 12, 60, 0.0 },
                    { 42, " 2", 21, 63, 0.0 },
                    { 41, " 1", 21, 22, 0.0 },
                    { 40, " 2", 20, 15, 0.0 },
                    { 39, " 1", 20, 64, 0.0 },
                    { 38, " 2", 19, 1, 0.0 },
                    { 37, " 1", 19, 66, 0.0 },
                    { 36, " 2", 18, 33, 0.0 },
                    { 35, " 1", 18, 6, 0.0 },
                    { 34, " 2", 17, 32, 0.0 },
                    { 33, " 1", 17, 20, 0.0 },
                    { 32, " 2", 16, 72, 0.0 },
                    { 31, " 1", 16, 54, 0.0 },
                    { 30, " 2", 15, 4, 0.0 },
                    { 29, " 1", 15, 28, 0.0 },
                    { 28, " 2", 14, 66, 0.0 },
                    { 27, " 1", 14, 53, 0.0 },
                    { 26, " 2", 13, 29, 0.0 },
                    { 25, " 1", 13, 33, 0.0 },
                    { 24, " 2", 12, 22, 0.0 },
                    { 87, " 1", 44, 19, 0.0 },
                    { 88, " 2", 44, 28, 0.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ReservedSeats",
                keyColumn: "ReservedSeatID",
                keyValue: 88);
        }
    }
}
