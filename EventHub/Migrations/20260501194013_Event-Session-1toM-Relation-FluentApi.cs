using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class EventSession1toMRelationFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Sessions",
                newName: "MyEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_MyEventId",
                table: "Sessions",
                column: "MyEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Events_MyEventId",
                table: "Sessions",
                column: "MyEventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Events_MyEventId",
                table: "Sessions");

            migrationBuilder.DropIndex(
                name: "IX_Sessions_MyEventId",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "MyEventId",
                table: "Sessions",
                newName: "EventId");
        }
    }
}
