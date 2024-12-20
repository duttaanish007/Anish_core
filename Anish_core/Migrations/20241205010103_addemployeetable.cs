using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Anish_core.Migrations
{
    /// <inheritdoc />
    public partial class addemployeetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Emp_Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Emp_Id", "Name", "city", "email", "phone" },
                values: new object[,]
                {
                    { 1, "Uttara", "Kolkata", "uttara@gmail.com", "8017723391" },
                    { 2, "Anish", "Kolkata", "anish@gmail.com", "8012458796" },
                    { 3, "Kau", "Kolkata", "Kau@gmail.com", "8045875985" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
