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
                            Id = new Guid("a17cfd31-807d-4a7a-98d5-af59041e2569"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6661),
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            ImageUrl = "images/products/labradorite.png",
                            Name = "Labradorite",
                            Price = 35.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6668)
                        },
                        new
                        {
                            Id = new Guid("1373e13a-0cc2-4bb1-99c4-a2c546ebdfe9"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6673),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "images/products/turquoise.png",
                            Name = "Turquoise",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6674)
                        },
                        new
                        {
                            Id = new Guid("89e4a898-6f64-4f00-b5bc-46fdd8f26764"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6676),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "images/products/star-garnet.png",
                            Name = "Star Garnet",
                            Price = 25.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6676)
                        },
                        new
                        {
                            Id = new Guid("a8358a75-5ede-40d5-9cc3-472b32cf9c6b"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6678),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "images/products/jasper.png",
                            Name = "Jasper",
                            Price = 20.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6678)
                        },
                        new
                        {
                            Id = new Guid("bf6d9f39-a8cd-4da8-9f37-5ff09518bd7a"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6680),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "images/products/fire-opal.png",
                            Name = "Fire Opal",
                            Price = 18.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6681)
                        },
                        new
                        {
                            Id = new Guid("0c2e1aa4-4c1e-410a-95ef-0e00435e900b"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6682),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "images/products/amethyst.png",
                            Name = "Amethyst",
                            Price = 22.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6683)
                        },
                        new
                        {
                            Id = new Guid("3687fd59-decf-449d-8c3b-84c555733847"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6685),
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            ImageUrl = "images/products/26-gauge-gold-wire.png",
                            Name = "26 Gauge Gold Wire",
                            Price = 9.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6685)
                        },
                        new
                        {
                            Id = new Guid("ccba52e9-a59e-456c-a9c9-97a89d765fbb"),
                            CreatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6687),
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            ImageUrl = "images/products/24-gauge-gold-wire.png",
                            Name = "24 Gauge Gold Wire",
                            Price = 8.0,
                            UpdatedDateTime = new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6688)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
