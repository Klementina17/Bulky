using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addImageUrlToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 4, 4, "Test" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "ISBN", "ImageUrl", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { 7, "Laura Phantom", 3, "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "FOT000000001", "", 25.0, 23.0, 20.0, 22.0, "Leaves and Wonders" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");
        }
    }
}
