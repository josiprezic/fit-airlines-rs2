using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "BirthDate", "ContactNumber", "Credit", "Email", "FirstName", "Gender", "isActive", "LastName", "MembershipTypeID", "PasswordHash", "Picture", "StartDate", "UserRoleID" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "063-124-542", 300.0, "admin@fit.ba", "Josip", "M", true, "Rezic", 5, "6Pl/upEE0epQR5SObftn+s2fW3M=", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(1995, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "312123534", 0.0, "boss@fit.ba", "Bosko", "M", true, "Bossovic", 5, "6Pl/upEE0epQR5SObftn+s2fW3M=", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, new DateTime(1994, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "112343237", 0.0, "manager@fit.ba", "Letelko", "M", true, "Naletilic", 1, "6Pl/upEE0epQR5SObftn+s2fW3M=", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, new DateTime(1993, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "653-866-555", 300.0, "cashier@fit.ba", "Blagajka", "F", true, "Blagajevic", 1, "6Pl/upEE0epQR5SObftn+s2fW3M=", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, new DateTime(1992, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "999-966-555", 1534.0, "member@fit.ba", "Fitovac", "M", true, "Studentovic", 1, "6Pl/upEE0epQR5SObftn+s2fW3M=", null, new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 5);
        }
    }
}
