using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KodaStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Product",
                columns: new[] { "ProductCode", "Category", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { "PR01", "Mie Ayam", "Mie Ayam Yamin", 13000m, 250 },
                    { "PR02", "Bakso", "Bakso Campuran", 17000m, 250 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR01");

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR02");
        }
    }
}
