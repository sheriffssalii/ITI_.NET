using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class new_edit_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[] { 1, "ahmed.ali@example.com", "Ahmed", "Ali", "pass1234" });
        }
    }
}
