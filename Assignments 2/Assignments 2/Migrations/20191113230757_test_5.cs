using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignments_2.Migrations
{
    public partial class test_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<int>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReactionTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(maxLength: 20, nullable: true),
                    IconURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReactionTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Friendwiths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendAversary = table.Column<DateTime>(nullable: false),
                    SecondPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendwiths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendwiths_People_SecondPersonId",
                        column: x => x.SecondPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstPersonId = table.Column<int>(nullable: true),
                    SecondPersonId = table.Column<int>(nullable: false),
                    DateTime_of_Msg = table.Column<DateTime>(nullable: false),
                    Msg_text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_People_FirstPersonId",
                        column: x => x.FirstPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_People_SecondPersonId",
                        column: x => x.SecondPersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostContent = table.Column<string>(nullable: false),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    PersonId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    PostetbypersonId = table.Column<int>(nullable: false),
                    Commentsid = table.Column<int>(nullable: true),
                    PostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_Commentsid",
                        column: x => x.Commentsid,
                        principalTable: "Comments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_People_PostetbypersonId",
                        column: x => x.PostetbypersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: false),
                    isPrimary = table.Column<bool>(nullable: false),
                    PostiddId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_PostiddId",
                        column: x => x.PostiddId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostVideo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(nullable: false),
                    isPrimary = table.Column<bool>(nullable: false),
                    PostId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostVideo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostVideo_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReactionDate = table.Column<DateTime>(nullable: false),
                    CommentIdid = table.Column<int>(nullable: true),
                    PostIdsId = table.Column<int>(nullable: true),
                    Reactiontypeeid = table.Column<int>(nullable: true),
                    ImageIdId = table.Column<int>(nullable: true),
                    PostVideoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reactions_Comments_CommentIdid",
                        column: x => x.CommentIdid,
                        principalTable: "Comments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_PostImages_ImageIdId",
                        column: x => x.ImageIdId,
                        principalTable: "PostImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Posts_PostIdsId",
                        column: x => x.PostIdsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_PostVideo_PostVideoId",
                        column: x => x.PostVideoId,
                        principalTable: "PostVideo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_ReactionTypes_Reactiontypeeid",
                        column: x => x.Reactiontypeeid,
                        principalTable: "ReactionTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Commentsid",
                table: "Comments",
                column: "Commentsid");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostetbypersonId",
                table: "Comments",
                column: "PostetbypersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendwiths_SecondPersonId",
                table: "Friendwiths",
                column: "SecondPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FirstPersonId",
                table: "Messages",
                column: "FirstPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SecondPersonId",
                table: "Messages",
                column: "SecondPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_PostiddId",
                table: "PostImages",
                column: "PostiddId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PersonId",
                table: "Posts",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PostVideo_PostId",
                table: "PostVideo",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_CommentIdid",
                table: "Reactions",
                column: "CommentIdid");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ImageIdId",
                table: "Reactions",
                column: "ImageIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostIdsId",
                table: "Reactions",
                column: "PostIdsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_PostVideoId",
                table: "Reactions",
                column: "PostVideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_Reactiontypeeid",
                table: "Reactions",
                column: "Reactiontypeeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friendwiths");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "PostVideo");

            migrationBuilder.DropTable(
                name: "ReactionTypes");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
