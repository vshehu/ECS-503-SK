using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Migrations
{
    public partial class next87 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Person_PersonIDId",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "PersonIDId",
                table: "Post",
                newName: "PersonnIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonIDId",
                table: "Post",
                newName: "IX_Post_PersonnIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_PersonnIDId",
                table: "Post",
                column: "PersonnIDId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Person_PersonnIDId",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "PersonnIDId",
                table: "Post",
                newName: "PersonIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonnIDId",
                table: "Post",
                newName: "IX_Post_PersonIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_PersonIDId",
                table: "Post",
                column: "PersonIDId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
