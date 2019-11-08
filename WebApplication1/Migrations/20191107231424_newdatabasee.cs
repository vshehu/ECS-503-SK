using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class newdatabasee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_Chat_ChatIDId",
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
                name: "FK_Reactions_Notification_NotioficationIdId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_People_ChatIDId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_NotificationIDId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_Friendwiths_ChatIDId",
                table: "Friendwiths");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chat",
                table: "Chat");

            migrationBuilder.DropColumn(
                name: "ChatIDId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "NotificationIDId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ChatIDId",
                table: "Friendwiths");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "Chat",
                newName: "Chats");

            migrationBuilder.AddColumn<int>(
                name: "PersonIDId",
                table: "Notifications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FriendwithsId",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeopleIDId",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chats",
                table: "Chats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_PersonIDId",
                table: "Notifications",
                column: "PersonIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_FriendwithsId",
                table: "Chats",
                column: "FriendwithsId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_PeopleIDId",
                table: "Chats",
                column: "PeopleIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Friendwiths_FriendwithsId",
                table: "Chats",
                column: "FriendwithsId",
                principalTable: "Friendwiths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_People_PeopleIDId",
                table: "Chats",
                column: "PeopleIDId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notifications_People_PersonIDId",
                table: "Notifications",
                column: "PersonIDId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Notifications_NotificationIdId",
                table: "Posts",
                column: "NotificationIdId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_Notifications_NotioficationIdId",
                table: "Reactions",
                column: "NotioficationIdId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Friendwiths_FriendwithsId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_People_PeopleIDId",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Notifications_People_PersonIDId",
                table: "Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Notifications_NotificationIdId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_Notifications_NotioficationIdId",
                table: "Reactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropIndex(
                name: "IX_Notifications_PersonIDId",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chats",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_FriendwithsId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_PeopleIDId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "PersonIDId",
                table: "Notifications");

            migrationBuilder.DropColumn(
                name: "FriendwithsId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "PeopleIDId",
                table: "Chats");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameTable(
                name: "Chats",
                newName: "Chat");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chat",
                table: "Chat",
                column: "Id");

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
                name: "FK_Friendwiths_Chat_ChatIDId",
                table: "Friendwiths",
                column: "ChatIDId",
                principalTable: "Chat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Reactions_Notification_NotioficationIdId",
                table: "Reactions",
                column: "NotioficationIdId",
                principalTable: "Notification",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
