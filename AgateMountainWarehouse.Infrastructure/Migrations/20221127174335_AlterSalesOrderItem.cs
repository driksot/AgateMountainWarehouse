using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterSalesOrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "SalesOrderItems");

            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "SalesOrderItems");

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("0b1acadd-9ff7-446b-b44c-d44665c90a3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("673a0752-1a7c-4c59-93c2-b18b0f1a3253"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("67934104-0acb-4c3a-bdda-c6f59531a0d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("a5a1e3a6-aced-4906-acc1-e95ad4e80db3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("ab34203d-3d43-4f32-b346-7151c4c77cd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("ae597b7a-2290-4d8b-9464-04c9b3778a45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("c5bfba91-ee59-4d1e-b0ca-2512a907102e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("f6622631-d1d2-4d2e-8a83-919bc57ed91a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8985), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8991), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8987), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 11, 27, 10, 43, 35, 146, DateTimeKind.Local).AddTicks(8976) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("0b1acadd-9ff7-446b-b44c-d44665c90a3b"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("673a0752-1a7c-4c59-93c2-b18b0f1a3253"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("67934104-0acb-4c3a-bdda-c6f59531a0d4"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a5a1e3a6-aced-4906-acc1-e95ad4e80db3"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ab34203d-3d43-4f32-b346-7151c4c77cd9"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ae597b7a-2290-4d8b-9464-04c9b3778a45"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c5bfba91-ee59-4d1e-b0ca-2512a907102e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f6622631-d1d2-4d2e-8a83-919bc57ed91a"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "SalesOrderItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "SalesOrderItems",
                type: "datetime2",
                nullable: true);

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
        }
    }
}
