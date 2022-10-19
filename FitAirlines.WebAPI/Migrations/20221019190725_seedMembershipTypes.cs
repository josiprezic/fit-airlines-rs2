using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedMembershipTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "MembershipTypeID", "BasicFoodDrinkDiscount", "BasicTicketDiscount", "IsBonusDrinkAvailable", "IsBonusMealAvailable", "IsExtraBaggageAvailable", "IsFITSandwichAvailable", "IsPriorityAvailable", "IsSeatChangeAvailable", "MembershipPrice", "ShortInfo", "Title" },
                values: new object[,]
                {
                    { 1, 0.0, 0.0, false, false, false, false, false, false, 0.0, "Default Membership Type", "Basic" },
                    { 2, 0.0, 0.0, false, false, true, false, true, false, 0.0, "With Blue FIT membership you have a priority while checking in and you are able to take the extra baggage.", "Blue" },
                    { 3, 0.0, 0.0, false, false, true, true, true, true, 0.0, "With Gold FIT membership you will get special FIT sandwich before every flight and if you would like to change a seat during the flight and if there are some other free seats, you will be able to do it.", "Gold" },
                    { 4, 0.0, 0.0, true, true, true, true, true, true, 0.0, "With Platinum FIT membership you will get one extra meal and one extra drink for free.", "Platinum" },
                    { 5, 1.0, 1.0, true, true, true, true, true, true, 0.0, "With Diamond FIT membership you will get an additional discount for your ticket as long as for all meals and drinks in the FIT menu.", "Diamond" }
                });

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 1,
                column: "Capacity",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 2,
                column: "Capacity",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 4,
                column: "Capacity",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 5,
                column: "Capacity",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 6,
                column: "Capacity",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 7,
                column: "Capacity",
                value: 90);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 8,
                column: "Capacity",
                value: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "MembershipTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "MembershipTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "MembershipTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "MembershipTypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MembershipTypes",
                keyColumn: "MembershipTypeID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 1,
                column: "Capacity",
                value: 84);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 2,
                column: "Capacity",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 4,
                column: "Capacity",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 5,
                column: "Capacity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 6,
                column: "Capacity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 7,
                column: "Capacity",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Planes",
                keyColumn: "PlaneID",
                keyValue: 8,
                column: "Capacity",
                value: 42);
        }
    }
}
