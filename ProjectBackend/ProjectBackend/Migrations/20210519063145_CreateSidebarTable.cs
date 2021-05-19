using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateSidebarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SosialIcons",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.CreateTable(
                name: "Sidebar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 300, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Subject = table.Column<string>(maxLength: 150, nullable: false),
                    Messaje = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidebar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: false),
                    Qualification = table.Column<string>(maxLength: 250, nullable: false),
                    AboutMe = table.Column<string>(maxLength: 250, nullable: false),
                    Degree = table.Column<string>(maxLength: 150, nullable: false),
                    Experience = table.Column<string>(maxLength: 150, nullable: false),
                    Hobbies = table.Column<string>(maxLength: 350, nullable: false),
                    Faculty = table.Column<string>(maxLength: 150, nullable: false),
                    ContactInformation = table.Column<string>(maxLength: 150, nullable: false),
                    MailMe = table.Column<string>(maxLength: 150, nullable: false),
                    CallNumber = table.Column<string>(maxLength: 150, nullable: false),
                    Skype = table.Column<string>(maxLength: 150, nullable: false),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDetails_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sidebar");

            migrationBuilder.DropTable(
                name: "TeacherDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SosialIcons",
                table: "Teachers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
