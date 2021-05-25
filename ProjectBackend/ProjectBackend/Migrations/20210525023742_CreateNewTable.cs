using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Events",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_CategoriesId",
                table: "Teacher",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoriesId",
                table: "Events",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoriesId",
                table: "Events",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Categories_CategoriesId",
                table: "Teacher",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoriesId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Categories_CategoriesId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_CategoriesId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Events_CategoriesId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Events");
        }
    }
}
