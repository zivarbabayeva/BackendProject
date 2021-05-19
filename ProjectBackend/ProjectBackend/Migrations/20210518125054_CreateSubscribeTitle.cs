using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateSubscribeTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Search = table.Column<string>(maxLength: 250, nullable: false),
                    Categories = table.Column<string>(maxLength: 250, nullable: false),
                    CSSEngineering = table.Column<string>(maxLength: 250, nullable: false),
                    PoliticalScience = table.Column<string>(maxLength: 250, nullable: false),
                    MicroBiology = table.Column<string>(maxLength: 250, nullable: false),
                    HTML5CSS3 = table.Column<string>(maxLength: 250, nullable: false),
                    WebDesign = table.Column<string>(maxLength: 250, nullable: false),
                    PHP = table.Column<string>(maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(maxLength: 250, nullable: false),
                    LatestPost = table.Column<string>(maxLength: 250, nullable: false),
                    SubTitle = table.Column<string>(maxLength: 250, nullable: false),
                    ByAlex = table.Column<string>(maxLength: 50, nullable: false),
                    Tag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscribe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");

            migrationBuilder.DropTable(
                name: "Subscribe");
        }
    }
}
