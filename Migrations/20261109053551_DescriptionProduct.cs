using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodaStore.Api.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "Product",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR01",
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Product",
                keyColumn: "ProductCode",
                keyValue: "PR02",
                column: "Description",
                value: "bakso urat besar, lainnya kecil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "Product");
        }
    }
}
