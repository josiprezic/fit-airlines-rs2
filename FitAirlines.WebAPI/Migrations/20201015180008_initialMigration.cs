using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitAirlines.WebAPI.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(maxLength: 50, nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 400, nullable: true),
                    Picture = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "MembershipTypes",
                columns: table => new
                {
                    MembershipTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 400, nullable: false),
                    MembershipPrice = table.Column<double>(nullable: false),
                    IsPriorityAvailable = table.Column<bool>(nullable: false),
                    IsExtraBaggageAvailable = table.Column<bool>(nullable: false),
                    IsFITSandwichAvailable = table.Column<bool>(nullable: false),
                    IsSeatChangeAvailable = table.Column<bool>(nullable: false),
                    IsBonusDrinkAvailable = table.Column<bool>(nullable: false),
                    IsBonusMealAvailable = table.Column<bool>(nullable: false),
                    BasicTicketDiscount = table.Column<double>(nullable: false),
                    BasicFoodDrinkDiscount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipTypes", x => x.MembershipTypeID);
                });

            migrationBuilder.CreateTable(
                name: "OfferTypes",
                columns: table => new
                {
                    OfferTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(maxLength: 20, nullable: false),
                    TypeDescription = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferTypes", x => x.OfferTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlaneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlaneName = table.Column<string>(maxLength: 50, nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    NumberOfColumns = table.Column<int>(nullable: false, defaultValueSql: "((6))"),
                    IsAvailable = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlaneID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    IsAbleToAddNewUsers = table.Column<bool>(nullable: false),
                    IsAbleToAddNewOffers = table.Column<bool>(nullable: false),
                    IsAbleToAddNewFlights = table.Column<bool>(nullable: false),
                    IsAbleToAddNewPlanes = table.Column<bool>(nullable: false),
                    IsAbleToAddUserCredits = table.Column<bool>(nullable: false),
                    IsAbleToAddNewReservations = table.Column<bool>(nullable: false),
                    IsAbleToAddNewPlaces = table.Column<bool>(nullable: false),
                    IsSuperUser = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleID);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(maxLength: 50, nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 400, nullable: true),
                    Picture = table.Column<byte[]>(nullable: true),
                    CountryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK__Cities__CountryI__276EDEB3",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferName = table.Column<string>(maxLength: 50, nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 400, nullable: true),
                    Picture = table.Column<byte[]>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OfferTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferID);
                    table.ForeignKey(
                        name: "FK__Offers__OfferTyp__398D8EEE",
                        column: x => x.OfferTypeID,
                        principalTable: "OfferTypes",
                        principalColumn: "OfferTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Gender = table.Column<string>(unicode: false, maxLength: 1, nullable: false),
                    Username = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordSalt = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    PasswordHash = table.Column<string>(maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    ContactNumber = table.Column<string>(maxLength: 50, nullable: false),
                    Picture = table.Column<byte[]>(nullable: true),
                    Credit = table.Column<double>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    isActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    UserRoleID = table.Column<int>(nullable: false),
                    MembershipTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK__Users__Membershi__4AB81AF0",
                        column: x => x.MembershipTypeID,
                        principalTable: "MembershipTypes",
                        principalColumn: "MembershipTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Users__UserRoleI__49C3F6B7",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    AirportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AirportName = table.Column<string>(maxLength: 50, nullable: false),
                    isAvailable = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    CityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.AirportID);
                    table.ForeignKey(
                        name: "FK__Airports__CityID__2C3393D0",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityID = table.Column<int>(nullable: false),
                    DestinationAirportID = table.Column<int>(nullable: false),
                    OfferID = table.Column<int>(nullable: false),
                    PlaneID = table.Column<int>(nullable: false),
                    AddedByUserID = table.Column<int>(nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    VoucherCode = table.Column<string>(maxLength: 10, nullable: true),
                    VoucherDiscountPercentage = table.Column<double>(nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PilotFullName = table.Column<string>(maxLength: 100, nullable: false),
                    FlightDuration = table.Column<TimeSpan>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ShortInfo = table.Column<string>(maxLength: 400, nullable: true),
                    Picture = table.Column<byte[]>(nullable: true),
                    Notes = table.Column<string>(maxLength: 400, nullable: true),
                    AvailableToMemberTypeID = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightID);
                    table.ForeignKey(
                        name: "FK__Flights__AddedBy__5165187F",
                        column: x => x.AddedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Flights__Availab__534D60F1",
                        column: x => x.AvailableToMemberTypeID,
                        principalTable: "MembershipTypes",
                        principalColumn: "MembershipTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Flights__CityID__4D94879B",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Flights__Destina__4E88ABD4",
                        column: x => x.DestinationAirportID,
                        principalTable: "Airports",
                        principalColumn: "AirportID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Flights__OfferID__4F7CD00D",
                        column: x => x.OfferID,
                        principalTable: "Offers",
                        principalColumn: "OfferID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Flights__PlaneID__5070F446",
                        column: x => x.PlaneID,
                        principalTable: "Planes",
                        principalColumn: "PlaneID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    FlightID = table.Column<int>(nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    BaseTicketPrice = table.Column<double>(nullable: false),
                    TotalDiscountPercentage = table.Column<double>(nullable: false),
                    IsValid = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    CashierID = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK__Reservati__Cashi__5BE2A6F2",
                        column: x => x.CashierID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Reservati__Fligh__5812160E",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Reservati__UserI__571DF1D5",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationID = table.Column<int>(nullable: false),
                    RatingValue = table.Column<double>(nullable: false),
                    Notes = table.Column<string>(maxLength: 200, nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                    table.ForeignKey(
                        name: "FK__Ratings__Reserva__5EBF139D",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ReservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReservedSeats",
                columns: table => new
                {
                    ReservedSeatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReservationID = table.Column<int>(nullable: false),
                    FlightID = table.Column<int>(nullable: false),
                    Direction = table.Column<string>(maxLength: 5, nullable: false),
                    SeatPrice = table.Column<double>(nullable: false),
                    SeatRow = table.Column<int>(nullable: false),
                    SeatColumn = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedSeats", x => x.ReservedSeatID);
                    table.ForeignKey(
                        name: "FK__ReservedS__Fligh__6383C8BA",
                        column: x => x.FlightID,
                        principalTable: "Flights",
                        principalColumn: "FlightID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ReservedS__Reser__628FA481",
                        column: x => x.ReservationID,
                        principalTable: "Reservations",
                        principalColumn: "ReservationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Airports__4E72794649BB424C",
                table: "Airports",
                column: "AirportName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CityID",
                table: "Airports",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "UQ__Countrie__E056F2015A80FCED",
                table: "Countries",
                column: "CountryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AddedByUserID",
                table: "Flights",
                column: "AddedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AvailableToMemberTypeID",
                table: "Flights",
                column: "AvailableToMemberTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CityID",
                table: "Flights",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DestinationAirportID",
                table: "Flights",
                column: "DestinationAirportID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_OfferID",
                table: "Flights",
                column: "OfferID");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_PlaneID",
                table: "Flights",
                column: "PlaneID");

            migrationBuilder.CreateIndex(
                name: "UQ__Membersh__2CB664DCBC49163C",
                table: "MembershipTypes",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Offers__07109364D9E5093F",
                table: "Offers",
                column: "OfferName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offers_OfferTypeID",
                table: "Offers",
                column: "OfferTypeID");

            migrationBuilder.CreateIndex(
                name: "UQ__OfferTyp__D4E7DFA86FF56EF0",
                table: "OfferTypes",
                column: "TypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Planes__7372E2C6E4398C69",
                table: "Planes",
                column: "PlaneName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ReservationID",
                table: "Ratings",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CashierID",
                table: "Reservations",
                column: "CashierID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FlightID",
                table: "Reservations",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserID",
                table: "Reservations",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_FlightID",
                table: "ReservedSeats",
                column: "FlightID");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedSeats_ReservationID",
                table: "ReservedSeats",
                column: "ReservationID");

            migrationBuilder.CreateIndex(
                name: "UQ__UserRole__2CB664DCF252F501",
                table: "UserRoles",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__A9D10534A6A00C66",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MembershipTypeID",
                table: "Users",
                column: "MembershipTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleID",
                table: "Users",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__536C85E455F25E7B",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "ReservedSeats");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "MembershipTypes");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "OfferTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
