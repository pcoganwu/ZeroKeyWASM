using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZeroKeyWASM.Server.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(10,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { new Guid("32b8b9f5-18d3-4099-b2a5-bd92d1772d0e"), "Book", 12.49m },
                    { new Guid("0f047c60-b9fa-49e7-a6be-70b3a63f46c6"), "Music CD", 14.99m },
                    { new Guid("40dcb307-591b-4506-a3a9-c922ae959d1d"), "Chocolate Bar", 0.85m },
                    { new Guid("2532b4ce-d379-473d-b685-39cd0296375c"), "Imported Box of Chocolate", 10.00m },
                    { new Guid("5e020105-ff60-4054-9466-5354527e08ae"), "Imported Bottle of Perfume", 47.50m },
                    { new Guid("8067d4a7-8622-467a-846f-659c0f8e4866"), "Imported Bottle of Perfume", 27.99m },
                    { new Guid("f46f2cbe-6121-4413-892f-e98667568598"), "Bottle of Perfume", 18.99m },
                    { new Guid("63963b77-7e8d-47ad-b960-e0763ac1a8c8"), "Packet of Headache Pills", 9.75m },
                    { new Guid("3e16c745-8c5b-4135-805d-b650aab3303a"), "Imported Box of Chocolate", 11.25m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
