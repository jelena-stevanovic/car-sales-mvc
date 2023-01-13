﻿// <auto-generated />
using System;
using CarsSelling.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarsSelling.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220415175504_IdentityAdded")]
    partial class IdentityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CarsSelling.Models.BodyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hatchback"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Coupe"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sedan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "SUV"
                        });
                });

            modelBuilder.Entity("CarsSelling.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BodyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("Displacement")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BodyTypeId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("MakeId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyTypeId = 3,
                            Contact = "5069324472",
                            Description = "The standard features of the Audi A4 40 Premium include 2.0L I - 4 201hp intercooled turbo engine, 7 - speed auto - shift manual transmission with overdrive 4 - wheel anti -lock brakes(ABS), side seat mounted airbags, SIDEGUARD curtain 1st and 2nd row overhead airbags, driver and passenger knee airbag, airbag occupancy sensor, automatic air conditioning, and cruise control.",
                            Displacement = 2000m,
                            FuelTypeId = 2,
                            ImagePath = "~/ImageUpload/659281fd-f4d4-4a40-a399-7ca60c0e6366.jpg",
                            MakeId = 1,
                            Model = "A4",
                            Power = 201,
                            Price = 39100m,
                            Year = 2022
                        },
                        new
                        {
                            Id = 2,
                            BodyTypeId = 1,
                            Contact = "6046927694",
                            Description = "The size of the DS5 is compact (only 4,53 m), and the trunk volume is 468 liters, with the rear seats folded down to 1.288 liters.",
                            Displacement = 1598m,
                            FuelTypeId = 1,
                            ImagePath = "~/ImageUpload/dbf2f3a3-e732-4d58-997e-904c9e5d4fc7.jpg",
                            MakeId = 2,
                            Model = "DS5",
                            Power = 156,
                            Price = 11450m,
                            Year = 2011
                        },
                        new
                        {
                            Id = 3,
                            BodyTypeId = 3,
                            Contact = "6147274670",
                            Description = "The Dacia Logan is a more family oriented vehicle. You get a huge load space – up to 1,518 litres with the seats folded flat – which is bigger than most of its mainstream competitors. ",
                            Displacement = 1400m,
                            FuelTypeId = 2,
                            ImagePath = "~/ImageUpload/3a20cb03-dade-418c-9f60-787f39ab207c.jpg",
                            MakeId = 4,
                            Model = "Logan",
                            Power = 90,
                            Price = 8360m,
                            Year = 2013
                        },
                        new
                        {
                            Id = 4,
                            BodyTypeId = 2,
                            Contact = "3063027591",
                            Description = "The 2022 BMW 4 Series blends class and performance in a way that few other luxury small cars can.The BMW 4 Series is an upmarket coupe that seats four. ",
                            Displacement = 1983m,
                            FuelTypeId = 1,
                            ImagePath = "~/ImageUpload/cd09419e-9509-4719-bcb2-123df35b0640.jpg",
                            MakeId = 3,
                            Model = "4",
                            Power = 228,
                            Price = 39870m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 5,
                            BodyTypeId = 1,
                            Contact = "4038889985",
                            Description = "This small two-door Audi hatch came equipped with a 2.0-liter turbocharged four-cylinder engine, with an optional diesel power plant.",
                            Displacement = 1197m,
                            FuelTypeId = 2,
                            ImagePath = "~/ImageUpload/2872ccba-ccc1-401a-870e-a76bff9d9503.jpg",
                            MakeId = 1,
                            Model = "A3",
                            Power = 110,
                            Price = 9995m,
                            Year = 2016
                        },
                        new
                        {
                            Id = 6,
                            BodyTypeId = 4,
                            Contact = "5062111872",
                            Description = "Citroen C5 Aircross is currently available in Diesel engine. The 1997 cc Diesel engine generates a power of 174.33@3750rpm and a torque of 400Nm@2000rpm.",
                            Displacement = 1499m,
                            FuelTypeId = 2,
                            ImagePath = "~/ImageUpload/92ebbdc6-5e7b-4d8e-a3e6-9fc6fa143eae.jpg",
                            MakeId = 2,
                            Model = "C5",
                            Power = 130,
                            Price = 30000m,
                            Year = 2022
                        });
                });

            modelBuilder.Entity("CarsSelling.Models.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bio-diesel"
                        });
                });

            modelBuilder.Entity("CarsSelling.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Citroen"
                        },
                        new
                        {
                            Id = 3,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dacia"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CarsSelling.Models.Car", b =>
                {
                    b.HasOne("CarsSelling.Models.BodyType", "BodyType")
                        .WithMany("Cars")
                        .HasForeignKey("BodyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsSelling.Models.FuelType", "FuelType")
                        .WithMany("Cars")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarsSelling.Models.Make", "Make")
                        .WithMany("Cars")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyType");

                    b.Navigation("FuelType");

                    b.Navigation("Make");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarsSelling.Models.BodyType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarsSelling.Models.FuelType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarsSelling.Models.Make", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
