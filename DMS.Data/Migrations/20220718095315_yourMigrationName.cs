using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class yourMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UsersUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_UsersUserId",
                table: "Documents");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UsersUserId",
                table: "Categories",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_UsersUserId",
                table: "Documents",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UsersUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Users_UsersUserId",
                table: "Documents");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UsersUserId",
                table: "Categories",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Users_UsersUserId",
                table: "Documents",
                column: "UsersUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
