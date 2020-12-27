using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitAirlines.WebAPI.Database
{
    public partial class FitAirlinesContext : DbContext
    {
        public FitAirlinesContext()
        {
        }

        public FitAirlinesContext(DbContextOptions<FitAirlinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Flights> Flights { get; set; }
        public virtual DbSet<MembershipTypes> MembershipTypes { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<OfferTypes> OfferTypes { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<ReservedSeats> ReservedSeats { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airports>(entity =>
            {
                entity.HasKey(e => e.AirportId);

                entity.HasIndex(e => e.AirportName)
                    .HasName("UQ__Airports__4E72794649BB424C")
                    .IsUnique();

                entity.Property(e => e.AirportId).HasColumnName("AirportID");

                entity.Property(e => e.AirportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasColumnName("isAvailable")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Airports)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Airports__CityID__2C3393D0");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.ShortInfo).HasMaxLength(400);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cities__CountryI__276EDEB3");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.HasIndex(e => e.CountryName)
                    .HasName("UQ__Countrie__E056F2015A80FCED")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortInfo).HasMaxLength(400);
            });

            modelBuilder.Entity<Flights>(entity =>
            {
                entity.HasKey(e => e.FlightId);

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.AddedByUserId).HasColumnName("AddedByUserID");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AvailableToMemberTypeId).HasColumnName("AvailableToMemberTypeID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.DestinationAirportId).HasColumnName("DestinationAirportID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).HasMaxLength(400);

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.PilotFullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PlaneId).HasColumnName("PlaneID");

                entity.Property(e => e.ShortInfo).HasMaxLength(400);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.VoucherCode).HasMaxLength(10);

                entity.HasOne(d => d.AddedByUser)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.AddedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__AddedBy__5165187F");

                entity.HasOne(d => d.AvailableToMemberType)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.AvailableToMemberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__Availab__534D60F1");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__CityID__4D94879B");

                entity.HasOne(d => d.DestinationAirport)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.DestinationAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__Destina__4E88ABD4");

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__OfferID__4F7CD00D");

                entity.HasOne(d => d.Plane)
                    .WithMany(p => p.Flights)
                    .HasForeignKey(d => d.PlaneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Flights__PlaneID__5070F446");
            });

            modelBuilder.Entity<MembershipTypes>(entity =>
            {
                entity.HasKey(e => e.MembershipTypeId);

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__Membersh__2CB664DCBC49163C")
                    .IsUnique();

                entity.Property(e => e.MembershipTypeId).HasColumnName("MembershipTypeID");

                entity.Property(e => e.IsFitsandwichAvailable).HasColumnName("IsFITSandwichAvailable");

                entity.Property(e => e.ShortInfo)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Offers>(entity =>
            {
                entity.HasKey(e => e.OfferId);

                entity.HasIndex(e => e.OfferName)
                    .HasName("UQ__Offers__07109364D9E5093F")
                    .IsUnique();

                entity.Property(e => e.OfferId).HasColumnName("OfferID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OfferName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OfferTypeId).HasColumnName("OfferTypeID");

                entity.Property(e => e.ShortInfo).HasMaxLength(400);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.OfferType)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.OfferTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Offers__OfferTyp__398D8EEE");
            });

            modelBuilder.Entity<OfferTypes>(entity =>
            {
                entity.HasKey(e => e.OfferTypeId);

                entity.HasIndex(e => e.TypeName)
                    .HasName("UQ__OfferTyp__D4E7DFA86FF56EF0")
                    .IsUnique();

                entity.Property(e => e.OfferTypeId).HasColumnName("OfferTypeID");

                entity.Property(e => e.TypeDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.PlaneId);

                entity.HasIndex(e => e.PlaneName)
                    .HasName("UQ__Planes__7372E2C6E4398C69")
                    .IsUnique();

                entity.Property(e => e.PlaneId).HasColumnName("PlaneID");

                entity.Property(e => e.IsAvailable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumberOfColumns).HasDefaultValueSql("((6))");

                entity.Property(e => e.PlaneName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId);

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.ReservationId).HasColumnName("ReservationID");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.ReservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ratings__Reserva__5EBF139D");
            });

            modelBuilder.Entity<Reservations>(entity =>
            {
                entity.HasKey(e => e.ReservationId);

                entity.Property(e => e.ReservationId).HasColumnName("ReservationID");

                entity.Property(e => e.CashierId).HasColumnName("CashierID");

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.IsValid)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.ReservationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Cashier)
                    .WithMany(p => p.ReservationsCashier)
                    .HasForeignKey(d => d.CashierId)
                    .HasConstraintName("FK__Reservati__Cashi__5BE2A6F2");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__Fligh__5812160E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReservationsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Reservati__UserI__571DF1D5");
            });

            modelBuilder.Entity<ReservedSeats>(entity =>
            {
                entity.HasKey(e => e.ReservedSeatId);

                entity.Property(e => e.ReservedSeatId).HasColumnName("ReservedSeatID");

                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.FlightId).HasColumnName("FlightID");

                entity.Property(e => e.ReservationId).HasColumnName("ReservationID");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.ReservedSeats)
                    .HasForeignKey(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReservedS__Fligh__6383C8BA");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.ReservedSeats)
                    .HasForeignKey(d => d.ReservationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ReservedS__Reser__628FA481");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.HasIndex(e => e.Title)
                    .HasName("UQ__UserRole__2CB664DCF252F501")
                    .IsUnique();

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.Email)
                    .HasName("UQ__Users__A9D10534A6A00C66")
                    .IsUnique();

                
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MembershipTypeId).HasColumnName("MembershipTypeID");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

               
                entity.HasOne(d => d.MembershipType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.MembershipTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__Membershi__4AB81AF0");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__UserRoleI__49C3F6B7");
            });
        }
    }
}
