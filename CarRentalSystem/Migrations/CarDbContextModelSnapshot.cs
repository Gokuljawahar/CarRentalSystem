﻿// <auto-generated />
using System;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRentalSystem.Migrations
{
    [DbContext(typeof(CarDbContext))]
    partial class CarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("CarRentalSystem.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("booked_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("booked_phone_number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("car_no")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("date_of_booking")
                        .HasColumnType("TEXT");

                    b.Property<string>("from_location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("to_location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}