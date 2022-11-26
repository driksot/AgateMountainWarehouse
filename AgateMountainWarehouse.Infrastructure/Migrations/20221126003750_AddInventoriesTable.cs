using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInventoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c2e1aa4-4c1e-410a-95ef-0e00435e900b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1373e13a-0cc2-4bb1-99c4-a2c546ebdfe9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3687fd59-decf-449d-8c3b-84c555733847"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89e4a898-6f64-4f00-b5bc-46fdd8f26764"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a17cfd31-807d-4a7a-98d5-af59041e2569"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8358a75-5ede-40d5-9cc3-472b32cf9c6b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf6d9f39-a8cd-4da8-9f37-5ff09518bd7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ccba52e9-a59e-456c-a9c9-97a89d765fbb"));

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

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
                    { new Guid("0c2e1aa4-4c1e-410a-95ef-0e00435e900b"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6682), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/amethyst.png", "Amethyst", 22.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6683) },
                    { new Guid("1373e13a-0cc2-4bb1-99c4-a2c546ebdfe9"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6673), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/turquoise.png", "Turquoise", 20.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6674) },
                    { new Guid("3687fd59-decf-449d-8c3b-84c555733847"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6685), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/26-gauge-gold-wire.png", "26 Gauge Gold Wire", 9.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6685) },
                    { new Guid("89e4a898-6f64-4f00-b5bc-46fdd8f26764"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6676), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/star-garnet.png", "Star Garnet", 25.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6676) },
                    { new Guid("a17cfd31-807d-4a7a-98d5-af59041e2569"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6661), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "images/products/labradorite.png", "Labradorite", 35.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6668) },
                    { new Guid("a8358a75-5ede-40d5-9cc3-472b32cf9c6b"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6678), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/jasper.png", "Jasper", 20.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6678) },
                    { new Guid("bf6d9f39-a8cd-4da8-9f37-5ff09518bd7a"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6680), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/fire-opal.png", "Fire Opal", 18.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6681) },
                    { new Guid("ccba52e9-a59e-456c-a9c9-97a89d765fbb"), new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6687), "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "images/products/24-gauge-gold-wire.png", "24 Gauge Gold Wire", 8.0, new DateTime(2022, 11, 24, 1, 20, 31, 408, DateTimeKind.Local).AddTicks(6688) }
                });
        }
    }
}
