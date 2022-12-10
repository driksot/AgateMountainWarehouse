﻿// <auto-generated />
using System;
using AgateMountainWarehouse.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    [DbContext(typeof(WarehouseDbContext))]
    partial class WarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a47b5f49-b82f-4d0b-9302-dfa4f93ad657"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("31c4b005-0057-41bd-9e4b-1b9dfb80ba27"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            QuantityOnHand = 7
                        },
                        new
                        {
                            Id = new Guid("95d026cc-68d2-4ddc-9ca4-f7a451fe33f1"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            QuantityOnHand = 3
                        },
                        new
                        {
                            Id = new Guid("6e0eada5-0e32-422d-aedb-3f76951ee276"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("1accebb7-8b48-4061-adbd-2f1b71024403"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            QuantityOnHand = 12
                        },
                        new
                        {
                            Id = new Guid("06c58145-c816-4508-8c61-8ad7e3658496"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            QuantityOnHand = 8
                        },
                        new
                        {
                            Id = new Guid("2d9cceda-a35e-4652-8c9e-684d24cccdc2"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            QuantityOnHand = 11
                        },
                        new
                        {
                            Id = new Guid("69e4a763-c117-4c98-abc8-20a3ae532eba"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                            QuantityOnHand = 9
                        });
                });

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(339),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/labradorite.png",
                            Name = "Labradorite",
                            Price = 35.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(348)
                        },
                        new
                        {
                            Id = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(357),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/turquoise.png",
                            Name = "Turquoise",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(357)
                        },
                        new
                        {
                            Id = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(359),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/star-garnet.jpg",
                            Name = "Star Garnet",
                            Price = 25.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(360)
                        },
                        new
                        {
                            Id = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(361),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/jasper.jpg",
                            Name = "Jasper",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(362)
                        },
                        new
                        {
                            Id = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(363),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/fire-opal.jpg",
                            Name = "Fire Opal",
                            Price = 18.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(364)
                        },
                        new
                        {
                            Id = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(365),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/amethyst.jpg",
                            Name = "Amethyst",
                            Price = 22.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(366)
                        },
                        new
                        {
                            Id = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(367),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "26 Gauge Gold Wire",
                            Price = 9.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(368)
                        },
                        new
                        {
                            Id = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                            CreatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(369),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "24 Gauge Gold Wire",
                            Price = 8.0,
                            UpdatedDateTime = new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(370)
                        });
                });

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.SalesOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.SalesOrderItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("SalesOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesOrderId");

                    b.ToTable("SalesOrderItems");
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2a523bc7-bdd1-4dc1-81ec-26e99c548740",
                            ConcurrencyStamp = "550b7cb3-ec28-4fb8-8ded-155bf10cdeb5",
                            Name = "Empolyee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "57bb2595-9b5a-41d1-8081-17be07cbe7b3",
                            ConcurrencyStamp = "154dbe17-a996-4a5c-988d-152ec06ce573",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.Inventory", b =>
                {
                    b.HasOne("AgateMountainWarehouse.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.SalesOrderItem", b =>
                {
                    b.HasOne("AgateMountainWarehouse.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgateMountainWarehouse.Domain.Entities.SalesOrder", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("SalesOrderId");

                    b.Navigation("Product");
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

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.SalesOrder", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
