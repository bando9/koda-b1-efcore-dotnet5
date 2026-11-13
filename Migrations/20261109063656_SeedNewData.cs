using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodaStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Product",
                columns: new[] { "ProductCode", "Category", "Description", "Name", "Price", "Stock" },
                values: new object[] { "PR03", "Bakso", "Bakso dg tetelan daging", "Bakso Halus", 15000m, 210 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR03");
        }
    }
}
