using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class testSeedCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CountryName", "Picture", "ShortInfo" },
                values: new object[] { 1, "Bosnia and Herzegovina", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryID",
                keyValue: 1);
        }
    }
}
