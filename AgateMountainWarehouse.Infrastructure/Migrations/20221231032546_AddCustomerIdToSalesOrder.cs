using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerIdToSalesOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "544b6752-03ba-41e6-a446-c7036157a0c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d50a1c4-8dd9-48cf-aff0-e3b326204da0");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "SalesOrders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a00db4cc-04f0-4677-a818-9e3c05dbfe8a", "755e05c0-6378-4179-ae13-7e3b4a7306ed", "Empolyee", "EMPLOYEE" },
                    { "d983bc32-c949-497a-8eb2-fb9cef5c69cc", "d6bdf823-c036-4f36-a294-9555633f3c52", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8598), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8619), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8592), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8621), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8613), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8589), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8601), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8628), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8595), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8604), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8624), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8569), new DateTime(2022, 12, 30, 20, 25, 45, 796, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a00db4cc-04f0-4677-a818-9e3c05dbfe8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d983bc32-c949-497a-8eb2-fb9cef5c69cc");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "SalesOrders",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "544b6752-03ba-41e6-a446-c7036157a0c4", "d8403aef-7ece-4da1-ba4c-e0b2d33d7eef", "Administrator", "ADMINISTRATOR" },
                    { "8d50a1c4-8dd9-48cf-aff0-e3b326204da0", "888cd8fa-62ea-4b70-b4b8-19aa2f67bb9a", "Empolyee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7991), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8006), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7987), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8009), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7998), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8002), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7985), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8000), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7993), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8013), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7989), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7996), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7982), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8004), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7970), new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.AddForeignKey(
                name: "FK_SalesOrders_Customers_CustomerId",
                table: "SalesOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }
    }
}
