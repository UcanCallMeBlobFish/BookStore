using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace bookstore.Migrations
{
    /// <inheritdoc />
    public partial class NewOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Name", "Author", "Capacity", "Category", "Price" },
                values: new object[,]
                {
                    { "Book 1", "Author 1", 10, "Category 1", 20 },
                    { "Book 2", "Author 2", 20, "Category 2", 30 },
                    { "Book 3", "Author 3", 30, "Category 3", 40 },
                    { "Book 4", "Author 4", 40, "Category 4", 50 },
                    { "Book 5", "Author 5", 50, "Category 5", 60 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Name",
                keyValue: "Book 1");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Name",
                keyValue: "Book 2");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Name",
                keyValue: "Book 3");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Name",
                keyValue: "Book 4");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Name",
                keyValue: "Book 5");
        }
    }
}
