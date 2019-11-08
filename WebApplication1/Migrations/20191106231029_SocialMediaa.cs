using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SocialMediaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 20, nullable: true),
                    PhoneNumber = table.Column<int>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ReactionTypes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Friendaversary = table.Column<DateTime>(nullable: false),
                    SecondPersonid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendwiths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friendwiths_People_SecondPersonid",
                        column: x => x.SecondPersonid,
                        principalTable: "People",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostContent = table.Column<string>(nullable: true),
                    PostedDate = table.Column<DateTime>(nullable: false),
                    Personidid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Posts_People_Personidid",
                        column: x => x.Personidid,
                        principalTable: "People",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    PostedBy = table.Column<int>(nullable: false),
                    Postidid = table.Column<int>(nullable: true),
                    Postetbyid = table.Column<int>(nullable: true),
                    Commentsparentidid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_Commentsparentidid",
                        column: x => x.Commentsparentidid,
                        principalTable: "Comments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_People_Postetbyid",
                        column: x => x.Postetbyid,
                        principalTable: "People",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_Postidid",
                        column: x => x.Postidid,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostImages",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PostContent = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false),
                    Postidid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_PostImages_Posts_Postidid",
                        column: x => x.Postidid,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReactionDate = table.Column<DateTime>(nullable: false),
                    Commentidid = table.Column<int>(nullable: true),
                    Postidid = table.Column<int>(nullable: true),
                    Reactiontypeeid = table.Column<int>(nullable: true),
                    Imageidid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Reactions_Comments_Commentidid",
                        column: x => x.Commentidid,
                        principalTable: "Comments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_PostImages_Imageidid",
                        column: x => x.Imageidid,
                        principalTable: "PostImages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Posts_Postidid",
                        column: x => x.Postidid,
                        principalTable: "Posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_ReactionTypes_Reactiontypeeid",
                        column: x => x.Reactiontypeeid,
                        principalTable: "ReactionTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Commentsparentidid",
                table: "Comments",
                column: "Commentsparentidid");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Postetbyid",
                table: "Comments",
                column: "Postetbyid");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Postidid",
                table: "Comments",
                column: "Postidid");

            migrationBuilder.CreateIndex(
                name: "IX_Friendwiths_SecondPersonid",
                table: "Friendwiths",
                column: "SecondPersonid");

            migrationBuilder.CreateIndex(
                name: "IX_PostImages_Postidid",
                table: "PostImages",
                column: "Postidid");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Personidid",
                table: "Posts",
                column: "Personidid");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_Commentidid",
                table: "Reactions",
                column: "Commentidid");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_Imageidid",
                table: "Reactions",
                column: "Imageidid");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_Postidid",
                table: "Reactions",
                column: "Postidid");

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
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostImages");

            migrationBuilder.DropTable(
                name: "ReactionTypes");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
