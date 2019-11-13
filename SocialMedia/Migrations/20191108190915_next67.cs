using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialMedia.Migrations
{
    public partial class next67 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Person_PersonidddId",
                table: "Post");

            migrationBuilder.RenameColumn(
                name: "PersonidddId",
                table: "Post",
                newName: "PersonIDId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonidddId",
                table: "Post",
                newName: "IX_Post_PersonIDId");

            migrationBuilder.CreateTable(
                name: "ArchivedPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArchivedDate = table.Column<DateTime>(nullable: false),
                    PostIdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArchivedPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArchivedPost_Post_PostIdId",
                        column: x => x.PostIdId,
                        principalTable: "Post",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArchivedPost_PostIdId",
                table: "ArchivedPost",
                column: "PostIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_PersonIDId",
                table: "Post",
                column: "PersonIDId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Person_PersonIDId",
                table: "Post");

            migrationBuilder.DropTable(
                name: "ArchivedPost");

            migrationBuilder.RenameColumn(
                name: "PersonIDId",
                table: "Post",
                newName: "PersonidddId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_PersonIDId",
                table: "Post",
                newName: "IX_Post_PersonidddId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Person_PersonidddId",
                table: "Post",
                column: "PersonidddId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
