using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AppStoreBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataUpdateapps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Apps",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 6, 1, "A challenging word game to test your vocabulary.", "Word Quest" },
                    { 7, 2, "Organize your day with ease.", "Daily Planner" },
                    { 8, 3, "Learn and master mathematics with engaging lessons.", "Math Genius" },
                    { 11, 1, "Become a hero in this action-packed game.", "Battle Heroes" },
                    { 12, 2, "A productivity app to manage team projects.", "Team Collaborator" },
                    { 13, 3, "Learn amazing facts about science.", "Science Facts" },
                    { 16, 1, "A thrilling racing game with amazing graphics.", "Racing Frenzy" },
                    { 18, 3, "Learn multiple languages with interactive lessons.", "Language Hub" },
                    { 19, 2, "Manage your expenses and save more.", "Budget Tracker" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "All fun games", "path/to/games/icon.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "Boost your productivity", "path/to/productivity/icon.png" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "Learn something new", "path/to/education/icon.png" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconPath", "Name" },
                values: new object[,]
                {
                    { 4, "Entertainment and leisure apps", "path/to/entertainment/icon.png", "Entertainment" },
                    { 5, "Health and fitness apps", "path/to/health/icon.png", "Health" }
                });

            migrationBuilder.InsertData(
                table: "Apps",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 4, 5, "Track your fitness and health goals.", "FitLife" },
                    { 5, 4, "An app for finding and streaming movies.", "Movie Night" },
                    { 9, 5, "Practice yoga and stay healthy.", "Yoga for All" },
                    { 10, 4, "Stream your favorite songs anytime.", "Music Streamer" },
                    { 14, 5, "Track your daily calorie intake easily.", "Calorie Counter" },
                    { 15, 4, "Challenge yourself with fun trivia questions.", "Trivia Master" },
                    { 17, 5, "Guided meditation sessions for relaxation.", "Mindful Meditation" },
                    { 20, 4, "Watch funny videos and stand-up comedy.", "Comedy Central" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Apps",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "IconPath" },
                values: new object[] { "", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "john@example.com", "John Doe", "hashed_password_here", "john_doe" },
                    { 2, "jane@example.com", "Jane Smith", "hashed_password_here", "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "AppId", "PurchaseDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 2, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });
        }
    }
}
