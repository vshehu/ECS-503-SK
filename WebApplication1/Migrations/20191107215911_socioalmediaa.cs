using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class socioalmediaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postidid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_People_SecondPersonid",
                table: "Friendwiths");

            migrationBuilder.DropForeignKey(
                name: "FK_PostImages_Posts_Postidid",
                table: "PostImages");

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Postidid",
                table: "PostImages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "PostImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SecondPersonid",
                table: "Friendwiths",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Postidid",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Postetbypersonid",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments",
                column: "Postetbypersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Postidid",
                table: "Comments",
                column: "Postidid",
                principalTable: "Posts",
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
                name: "FK_PostImages_Posts_Postidid",
                table: "PostImages",
                column: "Postidid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_Postidid",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Friendwiths_People_SecondPersonid",
                table: "Friendwiths");

            migrationBuilder.DropForeignKey(
                name: "FK_PostImages_Posts_Postidid",
                table: "PostImages");

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Postidid",
                table: "PostImages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "PostImages",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "SecondPersonid",
                table: "Friendwiths",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Postidid",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Postetbypersonid",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments",
                column: "Postetbypersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_Postidid",
                table: "Comments",
                column: "Postidid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Friendwiths_People_SecondPersonid",
                table: "Friendwiths",
                column: "SecondPersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostImages_Posts_Postidid",
                table: "PostImages",
                column: "Postidid",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
