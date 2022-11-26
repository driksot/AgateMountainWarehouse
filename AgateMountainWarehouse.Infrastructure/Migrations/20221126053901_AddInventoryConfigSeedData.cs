using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoryConfigSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12642164-3efa-4e2f-ab50-37513c4e4838"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("466ffa68-77e3-416c-bc15-658d3abe1532"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8100f26f-12d2-4b20-a3e7-a535123529e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a03c757-4608-49be-b7ac-a82f8b3e52a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c3440dc-4a58-466d-9945-d7b6db7c70ff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4de8dea-1c43-4885-b833-2659e399739f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c379f7a2-05de-425a-8fee-1d27d42138ae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cee2a195-c502-48a8-9558-19b2c4d1f34c"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDateTime", "Description", "ImageUrl", "Name", "Price", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "https://localhost:7252/StaticFiles//Images/amethyst.jpg", "Amethyst", 22.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358) },
                    { new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4353), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "https://localhost:7252/StaticFiles//Images/jasper.jpg", "Jasper", 20.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4354) },
                    { new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4351), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "https://localhost:7252/StaticFiles//Images/star-garnet.jpg", "Star Garnet", 25.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4352) },
                    { new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "https://localhost:7252/StaticFiles//Images/gold-wire.jpg", "26 Gauge Gold Wire", 9.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360) },
                    { new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "https://localhost:7252/StaticFiles//Images/fire-opal.jpg", "Fire Opal", 18.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356) },
                    { new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "https://localhost:7252/StaticFiles//Images/gold-wire.jpg", "24 Gauge Gold Wire", 8.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362) },
                    { new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4348), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "https://localhost:7252/StaticFiles//Images/turquoise.png", "Turquoise", 20.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4349) },
                    { new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4240), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "https://localhost:7252/StaticFiles//Images/labradorite.png", "Labradorite", 35.0, new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4250) }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("0afb05b5-417a-430e-88ed-d6bd54526ed5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("422b6b48-005d-4251-9724-adda280bd1b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("6322db9b-6263-4680-9a1f-6e679ec26663"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("b2fc1fb9-7ea1-4af0-b80b-3e7bf1e9babc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("c1e26cd7-be20-4d3e-b826-46e38e62864f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("d03072e0-0778-4d5b-8061-0d8b21f53ed5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("dfd123c9-9171-4615-b745-2d48faa121eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("ff94b9f9-da19-48a2-a205-af224fd38ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0afb05b5-417a-430e-88ed-d6bd54526ed5"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("422b6b48-005d-4251-9724-adda280bd1b3"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("6322db9b-6263-4680-9a1f-6e679ec26663"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b2fc1fb9-7ea1-4af0-b80b-3e7bf1e9babc"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c1e26cd7-be20-4d3e-b826-46e38e62864f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d03072e0-0778-4d5b-8061-0d8b21f53ed5"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("dfd123c9-9171-4615-b745-2d48faa121eb"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ff94b9f9-da19-48a2-a205-af224fd38ee0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDateTime", "Description", "ImageUrl", "Name", "Price", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("12642164-3efa-4e2f-ab50-37513c4e4838"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2115), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/24-gauge-gold-wire.png", "24 Gauge Gold Wire", 8.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2116) },
                    { new Guid("466ffa68-77e3-416c-bc15-658d3abe1532"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2102), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/turquoise.png", "Turquoise", 20.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2103) },
                    { new Guid("8100f26f-12d2-4b20-a3e7-a535123529e0"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2107), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/jasper.png", "Jasper", 20.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2107) },
                    { new Guid("8a03c757-4608-49be-b7ac-a82f8b3e52a8"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2111), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/amethyst.png", "Amethyst", 22.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2112) },
                    { new Guid("8c3440dc-4a58-466d-9945-d7b6db7c70ff"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2083), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "images/products/labradorite.png", "Labradorite", 35.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2097) },
                    { new Guid("b4de8dea-1c43-4885-b833-2659e399739f"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2105), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/star-garnet.png", "Star Garnet", 25.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2105) },
                    { new Guid("c379f7a2-05de-425a-8fee-1d27d42138ae"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2113), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/26-gauge-gold-wire.png", "26 Gauge Gold Wire", 9.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2114) },
                    { new Guid("cee2a195-c502-48a8-9558-19b2c4d1f34c"), new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2109), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/fire-opal.png", "Fire Opal", 18.0, new DateTime(2022, 11, 25, 17, 37, 50, 65, DateTimeKind.Local).AddTicks(2109) }
                });
        }
    }
}
