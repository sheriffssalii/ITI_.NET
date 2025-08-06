using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class seedall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Mobile Phone", "Ahmed" },
                    { 2, "Laptop", "Anas" },
                    { 3, "Accessories", "Ashraf" },
                    { 4, "HardWare", "Salma" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The iPhone 11 Pro Max is a high-end smartphone from Apple,featuring a powerful A13 Bionic chip with a hexa-core CPU for smooth and efficient performance.", "/images/iphone-11-pro-max.jpg", 10000m, 111, "iPhone 11 Pro Max" },
                    { 2, 1, "The iPhone 12 Pro Max, released in 2020, is Apple's flagship smartphone featuring a 6.7-inch Super Retina XDR OLED display and powered by the A14 Bionic chip..", "/images/iphone-12-pro-max.jpg", 20000m, 222, "iPhone 12 Pro Max" },
                    { 3, 1, "The iPhone 13 Pro Max is Apple's top-tier flagship smartphone released in 2021. It features a large 6.7-inch Super Retina XDR OLED display with ProMotion technology ", "/images/iphone-13-pro-max.jpg", 30000m, 333, "iPhone 13 Pro Max" },
                    { 4, 1, "The iPhone 14 Pro Max, released in 2022, features a 6.7-inch Super Retina XDR OLED display with ProMotion technology for a smooth 120Hz refresh rate. It is powered by the A16 Bionic chip, ensuring top-tier performance. The device boasts a triple-camera system with a 48 MP main sensor, enhanced low-light capabilities, and ProRAW/ProRes video recording.", "/images/iphone-14-pro-max.jpg", 40000m, 444, "iPhone 14 Pro Max" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);
        }
    }
}
