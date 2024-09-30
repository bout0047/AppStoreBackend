using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppStoreBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPopular",
                table: "Apps");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Apps");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_AppId",
                table: "Purchases",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Apps_CategoryId",
                table: "Apps",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apps_Categories_CategoryId",
                table: "Apps",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Apps_AppId",
                table: "Purchases",
                column: "AppId",
                principalTable: "Apps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apps_Categories_CategoryId",
                table: "Apps");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Apps_AppId",
                table: "Purchases");

            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Users_UserId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_AppId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_UserId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Apps_CategoryId",
                table: "Apps");

            migrationBuilder.AddColumn<bool>(
                name: "IsPopular",
                table: "Apps",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Apps",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
