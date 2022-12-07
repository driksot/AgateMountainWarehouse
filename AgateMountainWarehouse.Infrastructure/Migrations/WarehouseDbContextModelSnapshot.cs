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
                            Id = new Guid("c6080ff2-faf4-4d1f-ba68-858cfd2522aa"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("b73a0b9c-af2e-49cc-a37b-aa17e7918b4a"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            QuantityOnHand = 7
                        },
                        new
                        {
                            Id = new Guid("03fcdfc7-76c3-4670-8d32-7fa9ec07c0fa"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            QuantityOnHand = 3
                        },
                        new
                        {
                            Id = new Guid("b9e2fa20-6e3b-4def-9c2c-0e175b0ebfb5"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("693f0838-38cf-4c58-8b21-728444fca0d9"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            QuantityOnHand = 12
                        },
                        new
                        {
                            Id = new Guid("7340d574-c69f-4d4c-bfc2-4bd2471adf33"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            QuantityOnHand = 8
                        },
                        new
                        {
                            Id = new Guid("d07b04bf-9778-41b3-a996-38e564c8145d"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            QuantityOnHand = 11
                        },
                        new
                        {
                            Id = new Guid("e34e813e-ddcd-449e-b229-ced5bf2174d6"),
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
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1734),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/labradorite.png",
                            Name = "Labradorite",
                            Price = 35.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1742)
                        },
                        new
                        {
                            Id = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1747),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/turquoise.png",
                            Name = "Turquoise",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1747)
                        },
                        new
                        {
                            Id = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1749),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/star-garnet.jpg",
                            Name = "Star Garnet",
                            Price = 25.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1750)
                        },
                        new
                        {
                            Id = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1751),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/jasper.jpg",
                            Name = "Jasper",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1752)
                        },
                        new
                        {
                            Id = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1753),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/fire-opal.jpg",
                            Name = "Fire Opal",
                            Price = 18.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1754)
                        },
                        new
                        {
                            Id = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1755),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/amethyst.jpg",
                            Name = "Amethyst",
                            Price = 22.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1756)
                        },
                        new
                        {
                            Id = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1757),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "26 Gauge Gold Wire",
                            Price = 9.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1758)
                        },
                        new
                        {
                            Id = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                            CreatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1760),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "24 Gauge Gold Wire",
                            Price = 8.0,
                            UpdatedDateTime = new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1760)
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
