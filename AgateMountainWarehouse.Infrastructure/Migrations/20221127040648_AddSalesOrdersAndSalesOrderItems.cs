using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSalesOrdersAndSalesOrderItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SalesOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesOrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SalesOrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesOrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesOrderItems_SalesOrders_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "SalesOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("122653fa-d3f0-4aee-899b-9969caf240ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("14b82731-fd9c-4be4-938a-551ad3d7ebf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("2ee369a8-8069-4879-a5be-0582380d9815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("430f0908-8348-424f-9381-66f1bf711962"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("5b7a60fc-e398-4785-b246-70bb1138a0ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("806bcbc7-0e00-4210-ba0c-943ed4a97b9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("81dca1fe-e094-43e0-a990-d10ee5ccd7dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("8399be6c-d385-48f5-944f-c87ae5aeee2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6538), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6534), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6543), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6536), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6546), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 11, 26, 21, 6, 48, 427, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItems_ProductId",
                table: "SalesOrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrderItems_SalesOrderId",
                table: "SalesOrderItems",
                column: "SalesOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesOrderItems");

            migrationBuilder.DropTable(
                name: "SalesOrders");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("122653fa-d3f0-4aee-899b-9969caf240ce"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("14b82731-fd9c-4be4-938a-551ad3d7ebf3"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2ee369a8-8069-4879-a5be-0582380d9815"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("430f0908-8348-424f-9381-66f1bf711962"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("5b7a60fc-e398-4785-b246-70bb1138a0ef"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("806bcbc7-0e00-4210-ba0c-943ed4a97b9d"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("81dca1fe-e094-43e0-a990-d10ee5ccd7dc"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("8399be6c-d385-48f5-944f-c87ae5aeee2e"));

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4351), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4352) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4348), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4240), new DateTime(2022, 11, 25, 22, 39, 1, 575, DateTimeKind.Local).AddTicks(4250) });
        }
    }
}
