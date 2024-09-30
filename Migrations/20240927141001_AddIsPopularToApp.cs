using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppStoreBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddIsPopularToApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Apps",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Apps");
        }
    }
}
