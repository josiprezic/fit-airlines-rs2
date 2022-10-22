using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "BaseTicketPrice", "CashierID", "FlightID", "IsValid", "Notes", "ReservationDate", "TotalDiscountPercentage", "UserID" },
                values: new object[,]
                {
                    { 1, 0.0, null, 1, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 25, 0.0, null, 2, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 26, 0.0, null, 7, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 27, 0.0, 4, 12, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 28, 0.0, 4, 17, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 29, 0.0, null, 2, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 30, 0.0, null, 7, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 31, 0.0, 4, 12, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 32, 0.0, 4, 17, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 24, 0.0, 4, 16, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 33, 0.0, null, 3, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 35, 0.0, 4, 13, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 36, 0.0, 4, 18, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 37, 0.0, null, 4, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 38, 0.0, null, 9, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 39, 0.0, 4, 14, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 40, 0.0, 4, 19, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 41, 0.0, null, 5, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 42, 0.0, null, 10, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 34, 0.0, null, 8, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 23, 0.0, 4, 11, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 22, 0.0, null, 6, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 21, 0.0, null, 1, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 2, 0.0, null, 6, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 3, 0.0, 4, 11, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 4, 0.0, 4, 16, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 1 },
                    { 5, 0.0, null, 2, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 6, 0.0, null, 7, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 7, 0.0, 4, 12, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 8, 0.0, 4, 17, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 9, 0.0, null, 3, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 10, 0.0, null, 8, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 11, 0.0, 4, 13, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 12, 0.0, 4, 18, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 3 },
                    { 13, 0.0, null, 4, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 4 },
                    { 14, 0.0, null, 9, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 4 },
                    { 15, 0.0, 4, 14, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 4 },
                    { 16, 0.0, 4, 19, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 4 },
                    { 17, 0.0, null, 5, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 5 },
                    { 18, 0.0, null, 10, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 5 },
                    { 19, 0.0, 4, 15, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 5 },
                    { 20, 0.0, 4, 20, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 5 },
                    { 43, 0.0, 4, 15, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 },
                    { 44, 0.0, 4, 20, true, "", new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 44);
        }
    }
}
