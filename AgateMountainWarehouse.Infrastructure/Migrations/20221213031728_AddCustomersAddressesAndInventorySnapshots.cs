using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomersAddressesAndInventorySnapshots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "CustomerAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventorySnapshots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SnapshotTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SnapshotQuantity = table.Column<int>(type: "int", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorySnapshots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventorySnapshots_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_CustomerAddresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "CustomerAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37986ac3-d513-46e0-8ff6-fda7ec2f0faf", "588defae-5d27-496d-b152-b133175cad1e", "Empolyee", "EMPLOYEE" },
                    { "baa877c2-849b-462d-964d-354968f1918c", "419d69fa-0259-4173-9085-ab687db514c8", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("03d95ebd-a046-4649-b886-c22b8aa5714a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("1a8f4ee5-e1e9-4666-9309-121594c3d69e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("1e0a9157-9f55-4d6d-b7e8-20a1cce917cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("41e6def8-4eb1-4be8-a2b6-d2e9f11a19c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("88a8f2be-00de-4c21-b0ae-b5e4e9fa249e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("a9569f7a-a969-409c-b644-fd7eb9df532d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null },
                    { new Guid("c1837bdd-5195-4f47-a1e8-2ba38b1adb3c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("f3ec15b3-d2d7-45a4-b0ff-ab16adc3e035"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9734), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9729), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9726), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9737), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9733) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9739), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9723), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9708), new DateTime(2022, 12, 12, 20, 17, 28, 537, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_InventorySnapshots_InventoryId",
                table: "InventorySnapshots",
                column: "InventoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "InventorySnapshots");

            migrationBuilder.DropTable(
                name: "CustomerAddresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37986ac3-d513-46e0-8ff6-fda7ec2f0faf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "baa877c2-849b-462d-964d-354968f1918c");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("03d95ebd-a046-4649-b886-c22b8aa5714a"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1a8f4ee5-e1e9-4666-9309-121594c3d69e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1e0a9157-9f55-4d6d-b7e8-20a1cce917cc"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("41e6def8-4eb1-4be8-a2b6-d2e9f11a19c3"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("88a8f2be-00de-4c21-b0ae-b5e4e9fa249e"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a9569f7a-a969-409c-b644-fd7eb9df532d"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("c1837bdd-5195-4f47-a1e8-2ba38b1adb3c"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("f3ec15b3-d2d7-45a4-b0ff-ab16adc3e035"));

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
    }
}
