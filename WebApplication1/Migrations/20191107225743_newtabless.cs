using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class newtabless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_People_SecondPersonid",
                table: "Friendwiths");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_People_Personidid",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Comments_Commentidid",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_PostImages_Imageidid",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Posts_Postidid",
                table: "Reactions");

            migrationBuilder.RenameColumn(
                name: "Postidid",
                table: "Reactions",
                newName: "PostIdid");

            migrationBuilder.RenameColumn(
                name: "Imageidid",
                table: "Reactions",
                newName: "ImageIdid");

            migrationBuilder.RenameColumn(
                name: "Commentidid",
                table: "Reactions",
                newName: "CommentIdid");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reactions",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_Postidid",
                table: "Reactions",
                newName: "IX_Reactions_PostIdid");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_Imageidid",
                table: "Reactions",
                newName: "IX_Reactions_ImageIdid");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_Commentidid",
                table: "Reactions",
                newName: "IX_Reactions_CommentIdid");

            migrationBuilder.RenameColumn(
                name: "Personidid",
                table: "Posts",
                newName: "PersonIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_Personidid",
                table: "Posts",
                newName: "IX_Posts_PersonIdId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "People",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SecondPersonid",
                table: "Friendwiths",
                newName: "SecondPersonId");

            migrationBuilder.RenameColumn(
                name: "Friendaversary",
                table: "Friendwiths",
                newName: "FriendAversary");

            migrationBuilder.RenameIndex(
                name: "IX_Friendwiths_SecondPersonid",
                table: "Friendwiths",
                newName: "IX_Friendwiths_SecondPersonId");

            migrationBuilder.RenameColumn(
                name: "Postetbypersonid",
                table: "Comments",
                newName: "PostetbypersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Postetbypersonid",
                table: "Comments",
                newName: "IX_Comments_PostetbypersonId");

            migrationBuilder.AddColumn<int>(
                name: "NotioficationIdId",
                table: "Reactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationIdId",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatIDId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NotificationIDId",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChatIDId",
                table: "Friendwiths",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChatHistory = table.Column<string>(nullable: true),
                    IsOnline = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_NotioficationIdId",
                table: "Reactions",
                column: "NotioficationIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_NotificationIdId",
                table: "Posts",
                column: "NotificationIdId");

            migrationBuilder.CreateIndex(
                name: "IX_People_ChatIDId",
                table: "People",
                column: "ChatIDId");

            migrationBuilder.CreateIndex(
                name: "IX_People_NotificationIDId",
                table: "People",
                column: "NotificationIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendwiths_ChatIDId",
                table: "Friendwiths",
                column: "ChatIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_PostetbypersonId",
                table: "Comments",
                column: "PostetbypersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendwiths_Chat_ChatIDId",
                table: "Friendwiths",
                column: "ChatIDId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendwiths_People_SecondPersonId",
                table: "Friendwiths",
                column: "SecondPersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Chat_ChatIDId",
                table: "People",
                column: "ChatIDId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Notification_NotificationIDId",
                table: "People",
                column: "NotificationIDId",
                principalTable: "Notification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Notification_NotificationIdId",
                table: "Posts",
                column: "NotificationIdId",
                principalTable: "Notification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_People_PersonIdId",
                table: "Posts",
                column: "PersonIdId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Comments_CommentIdid",
                table: "Reactions",
                column: "CommentIdid",
                principalTable: "Comments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_PostImages_ImageIdid",
                table: "Reactions",
                column: "ImageIdid",
                principalTable: "PostImages",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Notification_NotioficationIdId",
                table: "Reactions",
                column: "NotioficationIdId",
                principalTable: "Notification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Posts_PostIdid",
                table: "Reactions",
                column: "PostIdid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_PostetbypersonId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_Chat_ChatIDId",
                table: "Friendwiths");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_People_SecondPersonId",
                table: "Friendwiths");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Chat_ChatIDId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Notification_NotificationIDId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Notification_NotificationIdId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_People_PersonIdId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Comments_CommentIdid",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_PostImages_ImageIdid",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Notification_NotioficationIdId",
                table: "Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Posts_PostIdid",
                table: "Reactions");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_NotioficationIdId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Posts_NotificationIdId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_People_ChatIDId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_NotificationIDId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Friendwiths_ChatIDId",
                table: "Friendwiths");

            migrationBuilder.DropColumn(
                name: "NotioficationIdId",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "NotificationIdId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ChatIDId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "NotificationIDId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ChatIDId",
                table: "Friendwiths");

            migrationBuilder.RenameColumn(
                name: "PostIdid",
                table: "Reactions",
                newName: "Postidid");

            migrationBuilder.RenameColumn(
                name: "ImageIdid",
                table: "Reactions",
                newName: "Imageidid");

            migrationBuilder.RenameColumn(
                name: "CommentIdid",
                table: "Reactions",
                newName: "Commentidid");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reactions",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_PostIdid",
                table: "Reactions",
                newName: "IX_Reactions_Postidid");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_ImageIdid",
                table: "Reactions",
                newName: "IX_Reactions_Imageidid");

            migrationBuilder.RenameIndex(
                name: "IX_Reactions_CommentIdid",
                table: "Reactions",
                newName: "IX_Reactions_Commentidid");

            migrationBuilder.RenameColumn(
                name: "PersonIdId",
                table: "Posts",
                newName: "Personidid");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_PersonIdId",
                table: "Posts",
                newName: "IX_Posts_Personidid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SecondPersonId",
                table: "Friendwiths",
                newName: "SecondPersonid");

            migrationBuilder.RenameColumn(
                name: "FriendAversary",
                table: "Friendwiths",
                newName: "Friendaversary");

            migrationBuilder.RenameIndex(
                name: "IX_Friendwiths_SecondPersonId",
                table: "Friendwiths",
                newName: "IX_Friendwiths_SecondPersonid");

            migrationBuilder.RenameColumn(
                name: "PostetbypersonId",
                table: "Comments",
                newName: "Postetbypersonid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostetbypersonId",
                table: "Comments",
                newName: "IX_Comments_Postetbypersonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments",
                column: "Postetbypersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendwiths_People_SecondPersonid",
                table: "Friendwiths",
                column: "SecondPersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_People_Personidid",
                table: "Posts",
                column: "Personidid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Comments_Commentidid",
                table: "Reactions",
                column: "Commentidid",
                principalTable: "Comments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_PostImages_Imageidid",
                table: "Reactions",
                column: "Imageidid",
                principalTable: "PostImages",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Posts_Postidid",
                table: "Reactions",
                column: "Postidid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
