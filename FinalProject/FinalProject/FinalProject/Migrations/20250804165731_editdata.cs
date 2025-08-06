using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class editdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 2, "anas.sherif@example.com", "Anas", "Sherif", "pass5678" },
                    { 3, "ashraf.fathy@example.com", "Ashraf", "Fathy", "pass9101112" },
                    { 4, "salma.mohamed@example.com", "Salma", "Mohamed", "pass13141516" },
                    { 5, "mona.mostafa@example.com", "Mona", "Mostafa", "pass17181920" },
                    { 6, "emad.shady@example.com", "Emad", "Shady", "pass21222324" },
                    { 7, "nancy.kareem@example.com", "Nancy", "Kareem", "pass25262728" },
                    { 8, "youssef.mahmoud@example.com", "Youssef", "Mahmoud", "pass29303132" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);
        }
    }
}
