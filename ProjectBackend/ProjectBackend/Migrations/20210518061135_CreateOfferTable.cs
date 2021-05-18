using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateOfferTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "CourseDetails");

            migrationBuilder.AddColumn<int>(
                name: "CoursesOfferId",
                table: "CourseDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TabName",
                table: "CourseDetails",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseDetails",
                table: "CourseDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseDetails_CoursesOfferId",
                table: "CourseDetails",
                column: "CoursesOfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseDetails_CoursesOffers_CoursesOfferId",
                table: "CourseDetails",
                column: "CoursesOfferId",
                principalTable: "CoursesOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseDetails_CoursesOffers_CoursesOfferId",
                table: "CourseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseDetails",
                table: "CourseDetails");

            migrationBuilder.DropIndex(
                name: "IX_CourseDetails_CoursesOfferId",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "CoursesOfferId",
                table: "CourseDetails");

            migrationBuilder.DropColumn(
                name: "TabName",
                table: "CourseDetails");

            migrationBuilder.RenameTable(
                name: "CourseDetails",
                newName: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Courses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");
        }
    }
}
