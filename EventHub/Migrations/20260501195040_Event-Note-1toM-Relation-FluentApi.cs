using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class EventNote1toMRelationFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Note_EventId",
                table: "Note",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Events_EventId",
                table: "Note",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Events_EventId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_EventId",
                table: "Note");
        }
    }
}
