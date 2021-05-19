using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherSpecialities_TeacherSpecialityId",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_TeacherSpecialityId",
                table: "Teacher",
                newName: "IX_Teacher_TeacherSpecialityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_TeacherSpecialities_TeacherSpecialityId",
                table: "Teacher",
                column: "TeacherSpecialityId",
                principalTable: "TeacherSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_Teacher_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_TeacherSpecialities_TeacherSpecialityId",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_Teacher_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_TeacherSpecialityId",
                table: "Teachers",
                newName: "IX_Teachers_TeacherSpecialityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherSpecialities_TeacherSpecialityId",
                table: "Teachers",
                column: "TeacherSpecialityId",
                principalTable: "TeacherSpecialities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
