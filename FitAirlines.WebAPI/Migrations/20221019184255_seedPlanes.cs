using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedPlanes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "PlaneID", "Capacity", "IsAvailable", "NumberOfColumns", "PlaneName" },
                values: new object[,]
                {
                    { 1, 84, true, 6, "Fitovac M20" },
                    { 2, 54, true, 6, "DLearningovac M60" },
                    { 3, 84, true, 6, "Mrezar 443" },
                    { 4, 12, true, 6, "Sistemac 1010" },
                    { 5, 18, true, 6, "Coder 17" },
                    { 6, 18, true, 6, "Mostarac 1000" },
                    { 7, 60, true, 6, "Studentovic 21" },
                    { 8, 42, true, 6, "Apsolvent 333" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 8);
        }
    }
}
