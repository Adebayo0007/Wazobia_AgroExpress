﻿// <auto-generated />
using System;
using Agro_Express.ApplicationContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agro_Express.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230410011950_now")]
    partial class now
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Agro_Express.Models.Address", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FullAddress")
                        .HasColumnType("longtext");

                    b.Property<int>("LocalGovernment")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Agro_Express.Models.Admin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = "37846734-732e-4149-8cec-6f43d1eb3f60",
                            UserId = "37846734-732e-4149-8cec-6f43d1eb3f60"
                        });
                });

            modelBuilder.Entity("Agro_Express.Models.Buyer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Agro_Express.Models.Farmer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Ranking")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("Agro_Express.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("AvailabilityDateFrom")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("AvailabilityDateTo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FarmerEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("FarmerId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FarmerUserName")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("FirstDimentionPicture")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("ForthDimentionPicture")
                        .HasColumnType("longblob");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Measurement")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<int>("ProductLocalGovernment")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<int>("ProductState")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<byte[]>("SecondDimentionPicture")
                        .HasColumnType("longblob");

                    b.Property<byte[]>("ThirdDimentionPicture")
                        .HasColumnType("longblob");

                    b.HasKey("Id");

                    b.HasIndex("FarmerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Agro_Express.Models.RequestedProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("BuyerId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("BuyerLocalGovernment")
                        .HasColumnType("int");

                    b.Property<string>("BuyerPhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("FarmerId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FarmerName")
                        .HasColumnType("longtext");

                    b.Property<string>("FarmerNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("OrderStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("FarmerId");

                    b.ToTable("RequestedProducts");
                });

            modelBuilder.Entity("Agro_Express.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("AddressId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRegistered")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("longblob");

                    b.Property<string>("Role")
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "37846734-732e-4149-8cec-6f43d1eb3f60",
                            DateCreated = new DateTime(2023, 4, 10, 2, 19, 50, 455, DateTimeKind.Local).AddTicks(4689),
                            Email = "tijaniadebayoabdllahi@gmail.com",
                            Gender = 1,
                            IsActive = true,
                            IsRegistered = true,
                            Name = "Adebayo Addullah",
                            Password = "$2b$10$LPHvoVRYrWElSsDaF/o4weKL4E5v97Ry7QtuCVU2CokzvYMissAg.",
                            PhoneNumber = "08087054632",
                            Role = "Admin",
                            UserName = "Modrator"
                        });
                });

            modelBuilder.Entity("Agro_Express.Models.Admin", b =>
                {
                    b.HasOne("Agro_Express.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("Agro_Express.Models.Admin", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Agro_Express.Models.Buyer", b =>
                {
                    b.HasOne("Agro_Express.Models.User", "User")
                        .WithOne("Buyer")
                        .HasForeignKey("Agro_Express.Models.Buyer", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Agro_Express.Models.Farmer", b =>
                {
                    b.HasOne("Agro_Express.Models.User", "User")
                        .WithOne("Farmer")
                        .HasForeignKey("Agro_Express.Models.Farmer", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Agro_Express.Models.Product", b =>
                {
                    b.HasOne("Agro_Express.Models.Farmer", "Farmer")
                        .WithMany("Products")
                        .HasForeignKey("FarmerId");

                    b.Navigation("Farmer");
                });

            modelBuilder.Entity("Agro_Express.Models.RequestedProduct", b =>
                {
                    b.HasOne("Agro_Express.Models.Buyer", "Buyer")
                        .WithMany("RequestedProducts")
                        .HasForeignKey("BuyerId");

                    b.HasOne("Agro_Express.Models.Farmer", "Farmer")
                        .WithMany("RequestedProducts")
                        .HasForeignKey("FarmerId");

                    b.Navigation("Buyer");

                    b.Navigation("Farmer");
                });

            modelBuilder.Entity("Agro_Express.Models.User", b =>
                {
                    b.HasOne("Agro_Express.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Agro_Express.Models.Buyer", b =>
                {
                    b.Navigation("RequestedProducts");
                });

            modelBuilder.Entity("Agro_Express.Models.Farmer", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("RequestedProducts");
                });

            modelBuilder.Entity("Agro_Express.Models.User", b =>
                {
                    b.Navigation("Admin");

                    b.Navigation("Buyer");

                    b.Navigation("Farmer");
                });
#pragma warning restore 612, 618
        }
    }
}
