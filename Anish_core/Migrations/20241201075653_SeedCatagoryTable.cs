using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Anish_core.Migrations
{
    /// <inheritdoc />
    public partial class SeedCatagoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Catagory_Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Anish" },
                    { 2, 2, "Uttara" },
                    { 3, 3, "Mau" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Catagory_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Catagory_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Catagory_Id",
                keyValue: 3);
        }
    }
}
