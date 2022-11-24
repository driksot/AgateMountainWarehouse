using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgateMountainWarehouse.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDateTime", "Description", "ImageUrl", "Name", "Price", "UpdatedDateTime" },
                values: new object[,]
                {
                    { new Guid("68bfbe72-dfae-41e3-902b-d08bf5568cc3"), new DateTime(2022, 11, 23, 22, 55, 4, 859, DateTimeKind.Local).AddTicks(9518), "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "images/products/turquoise.png", "Turquoise", 20.0, new DateTime(2022, 11, 23, 22, 55, 4, 859, DateTimeKind.Local).AddTicks(9518) },
                    { new Guid("75fa4c9e-55c0-4cec-90a7-a64f3a3dd289"), new DateTime(2022, 11, 23, 22, 55, 4, 859, DateTimeKind.Local).AddTicks(9503), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "images/products/labradorite.png", "Labradorite", 35.0, new DateTime(2022, 11, 23, 22, 55, 4, 859, DateTimeKind.Local).AddTicks(9512) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
