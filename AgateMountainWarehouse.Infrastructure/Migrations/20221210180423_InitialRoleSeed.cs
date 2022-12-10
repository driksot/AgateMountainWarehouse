using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("03fcdfc7-76c3-4670-8d32-7fa9ec07c0fa"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("693f0838-38cf-4c58-8b21-728444fca0d9"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("7340d574-c69f-4d4c-bfc2-4bd2471adf33"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b73a0b9c-af2e-49cc-a37b-aa17e7918b4a"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b9e2fa20-6e3b-4def-9c2c-0e175b0ebfb5"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c6080ff2-faf4-4d1f-ba68-858cfd2522aa"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d07b04bf-9778-41b3-a996-38e564c8145d"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e34e813e-ddcd-449e-b229-ced5bf2174d6"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a523bc7-bdd1-4dc1-81ec-26e99c548740", "550b7cb3-ec28-4fb8-8ded-155bf10cdeb5", "Empolyee", "EMPLOYEE" },
                    { "57bb2595-9b5a-41d1-8081-17be07cbe7b3", "154dbe17-a996-4a5c-988d-152ec06ce573", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("06c58145-c816-4508-8c61-8ad7e3658496"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("1accebb7-8b48-4061-adbd-2f1b71024403"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("2d9cceda-a35e-4652-8c9e-684d24cccdc2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("31c4b005-0057-41bd-9e4b-1b9dfb80ba27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("69e4a763-c117-4c98-abc8-20a3ae532eba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("6e0eada5-0e32-422d-aedb-3f76951ee276"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("95d026cc-68d2-4ddc-9ca4-f7a451fe33f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("a47b5f49-b82f-4d0b-9302-dfa4f93ad657"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(365), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(361), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(359), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(367), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(363), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(369), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(357), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(339), new DateTime(2022, 12, 10, 11, 4, 23, 648, DateTimeKind.Local).AddTicks(348) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a523bc7-bdd1-4dc1-81ec-26e99c548740");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57bb2595-9b5a-41d1-8081-17be07cbe7b3");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("06c58145-c816-4508-8c61-8ad7e3658496"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1accebb7-8b48-4061-adbd-2f1b71024403"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2d9cceda-a35e-4652-8c9e-684d24cccdc2"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("31c4b005-0057-41bd-9e4b-1b9dfb80ba27"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("69e4a763-c117-4c98-abc8-20a3ae532eba"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("6e0eada5-0e32-422d-aedb-3f76951ee276"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("95d026cc-68d2-4ddc-9ca4-f7a451fe33f1"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a47b5f49-b82f-4d0b-9302-dfa4f93ad657"));

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("03fcdfc7-76c3-4670-8d32-7fa9ec07c0fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("693f0838-38cf-4c58-8b21-728444fca0d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("7340d574-c69f-4d4c-bfc2-4bd2471adf33"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("b73a0b9c-af2e-49cc-a37b-aa17e7918b4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("b9e2fa20-6e3b-4def-9c2c-0e175b0ebfb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("c6080ff2-faf4-4d1f-ba68-858cfd2522aa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("d07b04bf-9778-41b3-a996-38e564c8145d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("e34e813e-ddcd-449e-b229-ced5bf2174d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1755), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1751), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1749), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1757), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1753), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1747), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1734), new DateTime(2022, 12, 6, 20, 11, 15, 359, DateTimeKind.Local).AddTicks(1742) });
        }
    }
}
