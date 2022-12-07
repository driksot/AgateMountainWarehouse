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
                            Id = new Guid("ed96cf57-d90e-4052-a3a1-38fe26771352"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("03963edb-e955-4720-aea8-934c65da9768"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            QuantityOnHand = 7
                        },
                        new
                        {
                            Id = new Guid("33aa00bf-b316-464f-aa78-4e3e40bb9328"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            QuantityOnHand = 3
                        },
                        new
                        {
                            Id = new Guid("cbc13bce-8751-4ddc-b0ef-c1580c5f0a26"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("a469ac22-e18c-41d2-bdeb-96e6299bcf68"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            QuantityOnHand = 12
                        },
                        new
                        {
                            Id = new Guid("b144c67d-7bb2-487a-b8bb-28930e9550be"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            QuantityOnHand = 8
                        },
                        new
                        {
                            Id = new Guid("f0a18658-0c7e-40d0-9d04-dff346a3a818"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            QuantityOnHand = 11
                        },
                        new
                        {
                            Id = new Guid("b00fa013-7a50-42e5-a5ce-69a88561658f"),
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
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1614),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/labradorite.png",
                            Name = "Labradorite",
                            Price = 35.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1625)
                        },
                        new
                        {
                            Id = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1630),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/turquoise.png",
                            Name = "Turquoise",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1630)
                        },
                        new
                        {
                            Id = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1632),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/star-garnet.jpg",
                            Name = "Star Garnet",
                            Price = 25.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1632)
                        },
                        new
                        {
                            Id = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1634),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/jasper.jpg",
                            Name = "Jasper",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1634)
                        },
                        new
                        {
                            Id = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1636),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/fire-opal.jpg",
                            Name = "Fire Opal",
                            Price = 18.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1636)
                        },
                        new
                        {
                            Id = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1638),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/amethyst.jpg",
                            Name = "Amethyst",
                            Price = 22.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1638)
                        },
                        new
                        {
                            Id = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1640),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "26 Gauge Gold Wire",
                            Price = 9.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1640)
                        },
                        new
                        {
                            Id = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                            CreatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1642),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "24 Gauge Gold Wire",
                            Price = 8.0,
                            UpdatedDateTime = new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1642)
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

            modelBuilder.Entity("AgateMountainWarehouse.Domain.Entities.SalesOrder", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
