using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class seedRatings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingID", "DateAdded", "Notes", "RatingValue", "ReservationID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A wonderful trip.", 4.0, 3 },
                    { 16, new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "For adults, we were pleasantly surprised by the diversity of our trip.", 1.0, 32 },
                    { 15, new DateTime(2022, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Our gulet cruise from Kos to Patmos was everything and more than expected.", 2.0, 28 },
                    { 14, new DateTime(2022, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "We definitely will be back!", 5.0, 8 },
                    { 13, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I don't understand all the hype about travelling.", 1.0, 24 },
                    { 12, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The holiday of a life time - our gulet adventure in the Dodecanese Greek Islands was without a doubt our favourite family trip.", 3.0, 4 },
                    { 11, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "I was disgusted.", 1.0, 43 },
                    { 10, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "What a wonderful experience! The two tour leaders who were archaeologists enthralled us with the history of the Islands.", 5.0, 19 },
                    { 9, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The comfort and beauty of the gulet, the incredibly caring crew, the delicious food, the history we learned from our competent and friendly leader, along with the stunning beauty of the islands.", 5.0, 39 },
                    { 8, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not bad.", 4.0, 15 },
                    { 7, new DateTime(2022, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Good overall", 4.0, 35 },
                    { 6, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Swimming in the most gorgeous coves, kayaking on crystal blue waters, hiking around ruins and into small remote villages and relaxing on the boat... it was the best trip ever.", 5.0, 11 },
                    { 5, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "I will never go to this kind of trips anymore.", 1.0, 31 },
                    { 4, new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Food was not delicious.", 4.0, 27 },
                    { 3, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boat was immaculate", 1.0, 7 },
                    { 2, new DateTime(2022, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't waste your time. But the food was good.", 3.0, 23 },
                    { 17, new DateTime(2022, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not only everything was perfect, but we felt, in every instance, that our guides and our gulet crew truly cared about us, both the kids and adults, and did their best to make this trip memorable.", 5.0, 12 },
                    { 18, new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "We had the most remarkable family tour with Peter Sommer Travels.", 5.0, 36 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "RatingID",
                keyValue: 18);
        }
    }
}
