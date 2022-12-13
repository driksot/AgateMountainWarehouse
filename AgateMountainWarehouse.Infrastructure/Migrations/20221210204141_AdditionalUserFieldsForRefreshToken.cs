using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFieldsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ae826bd-e582-421f-843a-8345525ba67f", "487924ec-1b37-4396-8b89-c7fe1b1bdf46", "Administrator", "ADMINISTRATOR" },
                    { "9a920546-4f0d-4a1b-9f90-189240eb4f0a", "560d9035-8c4c-458b-ad05-58d8813bd900", "Empolyee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("09104ea6-edec-4463-9d77-c39be7b70fac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("582b9bf7-aa1a-483a-ad64-6b9b1cd30379"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("898a2238-4bf6-46f2-b3a2-655579f11961"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("b082743a-726f-4768-80a6-d59b3e7eece2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("cef9ebd5-2ea7-44fd-a886-f9a34e2025a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("d03ccfb0-d220-4dce-b39c-b94f0205fac4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("e1791920-1add-417f-96b5-c0fa591946bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("fece4fc6-66ce-4a9e-b54a-344f1b872e43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7519), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7514), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7402), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7521), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7516), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7523), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7399), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7384), new DateTime(2022, 12, 10, 13, 41, 41, 587, DateTimeKind.Local).AddTicks(7395) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ae826bd-e582-421f-843a-8345525ba67f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a920546-4f0d-4a1b-9f90-189240eb4f0a");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("09104ea6-edec-4463-9d77-c39be7b70fac"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("582b9bf7-aa1a-483a-ad64-6b9b1cd30379"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("898a2238-4bf6-46f2-b3a2-655579f11961"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("b082743a-726f-4768-80a6-d59b3e7eece2"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("cef9ebd5-2ea7-44fd-a886-f9a34e2025a8"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("d03ccfb0-d220-4dce-b39c-b94f0205fac4"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e1791920-1add-417f-96b5-c0fa591946bd"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("fece4fc6-66ce-4a9e-b54a-344f1b872e43"));

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

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
    }
}
