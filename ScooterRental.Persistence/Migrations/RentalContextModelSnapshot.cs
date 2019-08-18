﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScooterRental.Persistence;

namespace ScooterRental.Persistence.Migrations
{
    [DbContext(typeof(RentalContext))]
    partial class RentalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("ScooterRental.Persistence.Dtos.DefectDtoDb", b =>
                {
                    b.Property<int>("DefectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DefectDescription");

                    b.Property<bool>("Resolved");

                    b.Property<int>("ScooterId");

                    b.Property<string>("UserId");

                    b.HasKey("DefectId");

                    b.ToTable("Defects");
                });

            modelBuilder.Entity("ScooterRental.Persistence.Dtos.RentalDtoDb", b =>
                {
                    b.Property<string>("RentalId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("RentalEnd");

                    b.Property<DateTime>("RentalStart");

                    b.Property<int>("ScooterId");

                    b.Property<string>("UserId");

                    b.HasKey("RentalId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("ScooterRental.Persistence.Dtos.ScooterDtoDb", b =>
                {
                    b.Property<int>("ScooterId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Defected");

                    b.Property<bool>("Rented");

                    b.HasKey("ScooterId");

                    b.ToTable("Scooters");
                });

            modelBuilder.Entity("ScooterRental.Persistence.Dtos.UserDtoDb", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
