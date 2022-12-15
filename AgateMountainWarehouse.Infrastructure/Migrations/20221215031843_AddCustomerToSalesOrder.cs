using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerToSalesOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerId",
                table: "SalesOrders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f72af64-9ab3-4bfe-8c3f-f352c3a7f9f7", "fefa21c4-3633-4764-afe1-59a87d020792", "Empolyee", "EMPLOYEE" },
                    { "ff1ce131-65f9-4bba-ad9d-43c0989be290", "f98f3db9-77d7-4104-9dc6-9662bb3aaaf7", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CreatedDateTime", "ProductId", "QuantityOnHand", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("1b1e0071-eaf9-4e10-b558-2ce5424b9545"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"), 4, null },
                    { new Guid("2fa36639-e77e-4105-93b5-487be13b3a4f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9af4201d-22d7-4579-bc40-341f345cb747"), 12, null },
                    { new Guid("4b023587-e04d-4393-ba87-f5eb5c026a3f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"), 11, null },
                    { new Guid("545d613b-8743-406d-b838-76ccff95cde1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"), 8, null },
                    { new Guid("572027e9-c77a-4df5-9532-76ee3e08885f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"), 7, null },
                    { new Guid("5c3b95f1-5c84-43ef-af96-07a333c2e5ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"), 4, null },
                    { new Guid("a1350f80-1523-4482-9313-a98bebf00176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"), 9, null },
                    { new Guid("e615a33f-5e7a-480a-89e2-b3336a496405"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"), 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8949), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8951), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8954), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8924), new DateTime(2022, 12, 14, 20, 18, 43, 223, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.CreateIndex(
                name: "IX_SalesOrders_CustomerId",
                table: "SalesOrders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DropIndex(
                name: "IX_SalesOrders_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f72af64-9ab3-4bfe-8c3f-f352c3a7f9f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff1ce131-65f9-4bba-ad9d-43c0989be290");

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("1b1e0071-eaf9-4e10-b558-2ce5424b9545"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("2fa36639-e77e-4105-93b5-487be13b3a4f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("4b023587-e04d-4393-ba87-f5eb5c026a3f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("545d613b-8743-406d-b838-76ccff95cde1"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("572027e9-c77a-4df5-9532-76ee3e08885f"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("5c3b95f1-5c84-43ef-af96-07a333c2e5ff"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("a1350f80-1523-4482-9313-a98bebf00176"));

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: new Guid("e615a33f-5e7a-480a-89e2-b3336a496405"));

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "SalesOrders");

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
        }
    }
}
