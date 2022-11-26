﻿// <auto-generated />
using System;
using AgateMountainWarehouse.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    [DbContext(typeof(WarehouseDbContext))]
    [Migration("20221126053901_AddInventoryConfigSeedData")]
    partial class AddInventoryConfigSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("c1e26cd7-be20-4d3e-b826-46e38e62864f"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("dfd123c9-9171-4615-b745-2d48faa121eb"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            QuantityOnHand = 7
                        },
                        new
                        {
                            Id = new Guid("422b6b48-005d-4251-9724-adda280bd1b3"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            QuantityOnHand = 3
                        },
                        new
                        {
                            Id = new Guid("ff94b9f9-da19-48a2-a205-af224fd38ee0"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            QuantityOnHand = 4
                        },
                        new
                        {
                            Id = new Guid("6322db9b-6263-4680-9a1f-6e679ec26663"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            QuantityOnHand = 12
                        },
                        new
                        {
                            Id = new Guid("d03072e0-0778-4d5b-8061-0d8b21f53ed5"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            QuantityOnHand = 8
                        },
                        new
                        {
                            Id = new Guid("b2fc1fb9-7ea1-4af0-b80b-3e7bf1e9babc"),
                            CreatedDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            QuantityOnHand = 11
                        },
                        new
                        {
                            Id = new Guid("0afb05b5-417a-430e-88ed-d6bd54526ed5"),
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
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4240),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/labradorite.png",
                            Name = "Labradorite",
                            Price = 35.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4250)
                        },
                        new
                        {
                            Id = new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4348),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/turquoise.png",
                            Name = "Turquoise",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4349)
                        },
                        new
                        {
                            Id = new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4351),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/star-garnet.jpg",
                            Name = "Star Garnet",
                            Price = 25.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4352)
                        },
                        new
                        {
                            Id = new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4353),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/jasper.jpg",
                            Name = "Jasper",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4354)
                        },
                        new
                        {
                            Id = new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/fire-opal.jpg",
                            Name = "Fire Opal",
                            Price = 18.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356)
                        },
                        new
                        {
                            Id = new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/amethyst.jpg",
                            Name = "Amethyst",
                            Price = 22.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358)
                        },
                        new
                        {
                            Id = new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "26 Gauge Gold Wire",
                            Price = 9.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360)
                        },
                        new
                        {
                            Id = new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                            CreatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "https://localhost:7252/StaticFiles//Images/gold-wire.jpg",
                            Name = "24 Gauge Gold Wire",
                            Price = 8.0,
                            UpdatedDateTime = new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362)
                        });
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
#pragma warning restore 612, 618
        }
    }
}
