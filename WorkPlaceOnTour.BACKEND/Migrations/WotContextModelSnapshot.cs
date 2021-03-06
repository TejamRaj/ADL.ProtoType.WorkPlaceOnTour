// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkPlaceOnTour.BACKEND.Services;

namespace WorkPlaceOnTour.BACKEND.Migrations
{
    [DbContext(typeof(WotContext))]
    partial class WotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.TourDestination", b =>
                {
                    b.Property<Guid>("TourId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CoverPhotoUrl");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Details")
                        .HasMaxLength(2000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("PopularityRating");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<int?>("WokrplaceBookingId");

                    b.HasKey("TourId");

                    b.HasIndex("WokrplaceBookingId");

                    b.ToTable("TourDestinations");
                });

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.WokrplaceBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillAmount");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTimeOffset>("EndDate");

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<int>("TourWorkplacesId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<int>("UserId");

                    b.Property<int>("WorkplaceId");

                    b.HasKey("Id");

                    b.HasIndex("WorkplaceId");

                    b.ToTable("WokrplaceBookings");
                });

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.Workplace", b =>
                {
                    b.Property<int>("WorkplaceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<Guid>("TourId");

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<string>("WorkplacePhotoUrl");

                    b.Property<int>("rate");

                    b.HasKey("WorkplaceId");

                    b.HasIndex("TourId");

                    b.ToTable("Workplaces");
                });

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.TourDestination", b =>
                {
                    b.HasOne("WorkPlaceOnTour.BACKEND.Entities.WokrplaceBooking")
                        .WithMany("TourDestinations")
                        .HasForeignKey("WokrplaceBookingId");
                });

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.WokrplaceBooking", b =>
                {
                    b.HasOne("WorkPlaceOnTour.BACKEND.Entities.Workplace", "workplace")
                        .WithMany()
                        .HasForeignKey("WorkplaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkPlaceOnTour.BACKEND.Entities.Workplace", b =>
                {
                    b.HasOne("WorkPlaceOnTour.BACKEND.Entities.TourDestination", "TourDestination")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
