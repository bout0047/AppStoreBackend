using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppStoreBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Purchases",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AppID",
                table: "Purchases",
                newName: "AppId");

            migrationBuilder.RenameColumn(
                name: "PurchaseID",
                table: "Purchases",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AppID",
                table: "Apps",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Apps",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Purchases",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "AppId",
                table: "Purchases",
                newName: "AppID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Purchases",
                newName: "PurchaseID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Apps",
                newName: "AppID");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Apps",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
