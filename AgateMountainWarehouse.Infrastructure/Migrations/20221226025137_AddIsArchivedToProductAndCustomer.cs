using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsArchivedToProductAndCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b27f638-19b6-4b80-b85c-4e2ba6ed4ed6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9668e296-0fc3-489e-8684-c18712a2cf1a");

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7991), "StaticFiles/Images/amethyst.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8006), "StaticFiles/Images/silver-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7987), "StaticFiles/Images/jasper.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8009), "StaticFiles/Images/copper-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7998), "StaticFiles/Images/agate.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8002), "StaticFiles/Images/malachite.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7985), "StaticFiles/Images/star-garnet.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8000), "StaticFiles/Images/carnelian.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7993), "StaticFiles/Images/gold-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8013), "StaticFiles/Images/sapphire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8013) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7989), "StaticFiles/Images/fire-opal.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7996), "StaticFiles/Images/gold-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7982), "StaticFiles/Images/turquoise.png", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8004), "StaticFiles/Images/silver-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8011), "StaticFiles/Images/copper-wire.jpg", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "IsArchived", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7970), "StaticFiles/Images/labradorite.png", false, new DateTime(2022, 12, 25, 19, 51, 37, 281, DateTimeKind.Local).AddTicks(7977) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "544b6752-03ba-41e6-a446-c7036157a0c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d50a1c4-8dd9-48cf-aff0-e3b326204da0");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b27f638-19b6-4b80-b85c-4e2ba6ed4ed6", "67724e32-a162-4a76-8e3d-1273e50ec1da", "Administrator", "ADMINISTRATOR" },
                    { "9668e296-0fc3-489e-8684-c18712a2cf1a", "aae6040d-7bb1-4057-98f1-508d183dbcb2", "Empolyee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c5ab034-4ba0-4fb5-9f07-13b06d8f155b"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3219), "https://localhost:7252/StaticFiles//Images/amethyst.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d1e2f73-94db-4559-b47b-5d7619e39dba"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3234), "https://localhost:7252/StaticFiles//Images/silver-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ef32bc9-536f-4231-8934-f3ce9d48d111"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3215), "https://localhost:7252/StaticFiles//Images/jasper.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f8e0392-db1c-4768-8a4f-c54b018f2f81"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3236), "https://localhost:7252/StaticFiles//Images/copper-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57aea388-8f33-4975-aea7-a587855d87ee"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3225), "https://localhost:7252/StaticFiles//Images/agate.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b001338-1a4f-496c-8d26-dee9e111c24d"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3229), "https://localhost:7252/StaticFiles//Images/malachite.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6f6977f5-a099-4add-94f3-1fdcb5e06b92"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3213), "https://localhost:7252/StaticFiles//Images/star-garnet.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fc19f3c-5426-4dd4-a1e2-aaebc14ce18a"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3227), "https://localhost:7252/StaticFiles//Images/carnelian.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7aad8902-45d5-4185-a2e6-cf466abbbb84"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3221), "https://localhost:7252/StaticFiles//Images/gold-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9465fec5-3ee4-4d25-ba84-69f3ec21336a"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3240), "https://localhost:7252/StaticFiles//Images/sapphire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9af4201d-22d7-4579-bc40-341f345cb747"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3217), "https://localhost:7252/StaticFiles//Images/fire-opal.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae5e0036-8551-4dab-9e41-674d27b4a8b2"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3223), "https://localhost:7252/StaticFiles//Images/gold-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8552865-4078-4e4b-8d20-ff0d14d87d8d"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3210), "https://localhost:7252/StaticFiles//Images/turquoise.png", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ba12294f-779c-425e-a2d0-9a6a69e8c009"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3231), "https://localhost:7252/StaticFiles//Images/silver-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc7e516c-5e5b-4949-8384-414cac54e563"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3238), "https://localhost:7252/StaticFiles//Images/copper-wire.jpg", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffbc3199-8546-4699-a532-c10a32c564cc"),
                columns: new[] { "CreatedDateTime", "ImageUrl", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3197), "https://localhost:7252/StaticFiles//Images/labradorite.png", new DateTime(2022, 12, 20, 7, 16, 43, 337, DateTimeKind.Local).AddTicks(3205) });
        }
    }
}
