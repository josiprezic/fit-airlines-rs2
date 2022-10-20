using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedOfferTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OfferTypes",
                columns: new[] { "OfferTypeID", "TypeDescription", "TypeName" },
                values: new object[] { 1, "This offer type reffers to offers containing flights which share the same regional part of the specific area/continent.", "Regional" });

            migrationBuilder.InsertData(
                table: "OfferTypes",
                columns: new[] { "OfferTypeID", "TypeDescription", "TypeName" },
                values: new object[] { 2, "This offer type reffers to offers containing flights which belongs to the same season of the year", "Seasonal" });

            migrationBuilder.InsertData(
                table: "OfferTypes",
                columns: new[] { "OfferTypeID", "TypeDescription", "TypeName" },
                values: new object[] { 3, "This offer type reffers to offers containing flights which belongs to the offers of special/uncategorized types.", "Special" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OfferTypes",
                keyColumn: "OfferTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfferTypes",
                keyColumn: "OfferTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OfferTypes",
                keyColumn: "OfferTypeID",
                keyValue: 3);
        }
    }
}
