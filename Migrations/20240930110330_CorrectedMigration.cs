using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppStoreBackend.Migrations
{
    /// <inheritdoc />
    public partial class CorrectedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "IconPath");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "CategoryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IconPath",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Description");
        }
    }
}
