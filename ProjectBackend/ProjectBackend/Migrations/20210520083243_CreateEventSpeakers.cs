using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackend.Migrations
{
    public partial class CreateEventSpeakers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Events_EventId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_Speakers_Eventdetails_EventdetailsId",
                table: "Speakers");

            migrationBuilder.DropIndex(
                name: "IX_Speakers_EventdetailsId",
                table: "Speakers");

            migrationBuilder.DropIndex(
                name: "IX_EventSpeakers_EventId",
                table: "EventSpeakers");

            migrationBuilder.DropColumn(
                name: "EventdetailsId",
                table: "Speakers");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "EventSpeakers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventdetailsId",
                table: "Speakers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "EventSpeakers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_EventdetailsId",
                table: "Speakers",
                column: "EventdetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventSpeakers_EventId",
                table: "EventSpeakers",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Events_EventId",
                table: "EventSpeakers",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Speakers_Eventdetails_EventdetailsId",
                table: "Speakers",
                column: "EventdetailsId",
                principalTable: "Eventdetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
