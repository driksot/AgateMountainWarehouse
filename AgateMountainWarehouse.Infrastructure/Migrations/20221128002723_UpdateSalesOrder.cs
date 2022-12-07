using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSalesOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "TotalCost",
                table: "SalesOrders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("03963edb-e955-4720-aea8-934c65da9768"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("33aa00bf-b316-464f-aa78-4e3e40bb9328"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("a469ac22-e18c-41d2-bdeb-96e6299bcf68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("b00fa013-7a50-42e5-a5ce-69a88561658f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("b144c67d-7bb2-487a-b8bb-28930e9550be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("cbc13bce-8751-4ddc-b0ef-c1580c5f0a26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("ed96cf57-d90e-4052-a3a1-38fe26771352"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("f0a18658-0c7e-40d0-9d04-dff346a3a818"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1638), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1632), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1640), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1642), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 11, 27, 17, 27, 23, 253, DateTimeKind.Local).AddTicks(1625) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("03963edb-e955-4720-aea8-934c65da9768"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("33aa00bf-b316-464f-aa78-4e3e40bb9328"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a469ac22-e18c-41d2-bdeb-96e6299bcf68"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b00fa013-7a50-42e5-a5ce-69a88561658f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b144c67d-7bb2-487a-b8bb-28930e9550be"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("cbc13bce-8751-4ddc-b0ef-c1580c5f0a26"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("ed96cf57-d90e-4052-a3a1-38fe26771352"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f0a18658-0c7e-40d0-9d04-dff346a3a818"));

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "SalesOrders");

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
    }
}
