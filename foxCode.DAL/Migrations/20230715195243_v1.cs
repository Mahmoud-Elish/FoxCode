using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foxCode.DAL.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Kids" },
                    { new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Women" },
                    { new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"), "Men" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("046493c5-3688-4d10-833f-4e0f8b872d18"), new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Elegant dress for women", "Women's Swimsuits", 49.99m },
                    { new Guid("16a66462-1880-4d3b-8750-1104f62eaaac"), new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Elegant dress for women", "Women's Dress", 49.99m },
                    { new Guid("1856ec62-4ea0-4cad-aa6f-05492bbaa138"), new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"), "Comfortable cotton t-shirt for men", "Men's Jackets", 15.99m },
                    { new Guid("2e7bee36-bcfc-4265-a875-f4cde38deaf0"), new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Colorful shoes for kids", "Kids' Jackets", 29.99m },
                    { new Guid("6f9a5461-2b0a-44a0-88a5-f9ca94463764"), new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Colorful shoes for kids", "Kids' T-Shirt", 29.99m },
                    { new Guid("8fd85c1b-a6a9-4cfb-9224-095523e82b7a"), new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Colorful shoes for kids", "Kids' Pants", 29.99m },
                    { new Guid("917f4d1d-8451-4775-a3cd-5ff4e66067d9"), new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Elegant dress for women", "Women's Jackets", 49.99m },
                    { new Guid("984775d6-57a7-4330-867e-6275067c4f20"), new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Elegant dress for women", "Women's Jeans", 49.99m },
                    { new Guid("ae35e72a-4e57-451a-8146-0a54595ee82b"), new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"), "Comfortable cotton t-shirt for men", "Men's T-Shirt", 15.99m },
                    { new Guid("bf58f84e-8802-44d2-bdc9-a0cae047b460"), new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"), "Elegant dress for women", "Women's Leggings", 49.99m },
                    { new Guid("d2506798-c1da-41fc-a6ff-0e74d20ff250"), new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Colorful shoes for kids", "Kids' Shorts", 29.99m },
                    { new Guid("d867ec5f-ac65-4610-8baf-f6f512dfd642"), new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"), "Colorful shoes for kids", "Kids' Shoes", 29.99m },
                    { new Guid("e3581857-9328-404b-872c-7d4128bd5158"), new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"), "Comfortable cotton t-shirt for men", "Men's Pants", 15.99m },
                    { new Guid("f657e27b-4000-419a-94f6-770d24cc4952"), new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"), "Comfortable cotton t-shirt for men", "Men's Shorts", 15.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
