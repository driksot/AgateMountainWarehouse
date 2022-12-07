using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IdentityTablesCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
