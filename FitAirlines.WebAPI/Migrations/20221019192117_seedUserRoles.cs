using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleID", "IsAbleToAddNewFlights", "IsAbleToAddNewOffers", "IsAbleToAddNewPlaces", "IsAbleToAddNewPlanes", "IsAbleToAddNewReservations", "IsAbleToAddNewUsers", "IsAbleToAddUserCredits", "IsSuperUser", "Title" },
                values: new object[,]
                {
                    { 1, true, true, true, true, true, true, true, true, "Administrator" },
                    { 2, false, false, false, false, false, true, false, false, "Boss" },
                    { 3, true, true, true, true, false, false, false, false, "Flight Offers Manager" },
                    { 4, false, false, false, false, true, false, true, false, "Cashier" },
                    { 5, false, false, false, false, true, false, false, false, "FIT Member" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleID",
                keyValue: 5);
        }
    }
}
