using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub.Migrations
{
    /// <inheritdoc />
    public partial class OrgEvent1toMRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrganizerId",
                table: "Events",
                newName: "MyOrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_MyOrganizerId",
                table: "Events",
                column: "MyOrganizerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Organizers_MyOrganizerId",
                table: "Events",
                column: "MyOrganizerId",
                principalTable: "Organizers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Organizers_MyOrganizerId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_MyOrganizerId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "MyOrganizerId",
                table: "Events",
                newName: "OrganizerId");
        }
    }
}
