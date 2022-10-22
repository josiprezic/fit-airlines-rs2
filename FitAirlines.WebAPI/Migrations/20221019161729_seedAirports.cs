using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "AirportID", "AirportName", "CityID", "isAvailable" },
                values: new object[,]
                {
                    { 1, "Kielce Lotnisko Glowne", 1, true },
                    { 22, "Osijek Airport", 16, true },
                    { 23, "Makarska Airport", 17, true },
                    { 24, "Zadar Airport", 18, true },
                    { 25, "Auckland Airport", 19, true },
                    { 26, "Wellington Airport", 20, true },
                    { 27, "Christchurch Airport", 21, true },
                    { 28, "Hamilton Airport", 22, true },
                    { 21, "Hvar Airport", 15, true },
                    { 29, "Gold Coast Airport", 23, true },
                    { 31, "Darwin Airport", 25, true },
                    { 32, "Adelaide Airport", 26, true },
                    { 33, "Hobart Airport", 27, true },
                    { 34, "Tokyo Main Airport", 28, true },
                    { 35, "Tokyo Oyo Airport", 28, true },
                    { 36, "Tokyo Takahuma Airport", 28, true },
                    { 37, "Yokohama Airport", 29, true },
                    { 30, "Cairns Airport", 24, true },
                    { 38, "Nagoya Airport", 30, true },
                    { 20, "Rijeka Airport", 14, true },
                    { 18, "Split Airport", 12, true },
                    { 2, "Kielce-Cminsk Lotnisko", 1, true },
                    { 3, "Kielce Lotnisko Narodowe", 1, true },
                    { 4, "Wroclaw Lotnisko Biskupin", 2, true },
                    { 5, "Lotnisko Morskie Oko", 2, true },
                    { 6, "Lotnisko Hala Stulecia", 2, true },
                    { 7, "Krakow Lotnisko Narodowe", 3, true },
                    { 8, "Gdansk Lotnisko", 4, true },
                    { 19, "Cilipi Airport", 13, true },
                    { 9, "Warsaw Lotnisko Glowne Narodowe", 5, true },
                    { 11, "Gdynia Airport", 7, true },
                    { 12, "Katowice Airport", 8, true },
                    { 13, "Gliwice Airport", 9, true },
                    { 14, "Bialystok Airport", 10, true },
                    { 15, "Zagreb Main Airport", 11, true },
                    { 16, "Dubrava Airport", 11, true },
                    { 17, "Jelacic Airport", 11, true },
                    { 10, "Lodz Airport", 6, true },
                    { 39, "Kyoto Airport", 31, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "AirportID",
                keyValue: 39);
        }
    }
}
