using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Socialmedia2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_Postetbyid",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostDate",
                table: "PostImages");

            migrationBuilder.DropColumn(
                name: "PostedBy",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "PostContent",
                table: "PostImages",
                newName: "FileName");

            migrationBuilder.RenameColumn(
                name: "Postetbyid",
                table: "Comments",
                newName: "Postetbypersonid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Postetbyid",
                table: "Comments",
                newName: "IX_Comments_Postetbypersonid");

            migrationBuilder.AddColumn<bool>(
                name: "isPrimary",
                table: "PostImages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments",
                column: "Postetbypersonid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_Postetbypersonid",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "isPrimary",
                table: "PostImages");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "PostImages",
                newName: "PostContent");

            migrationBuilder.RenameColumn(
                name: "Postetbypersonid",
                table: "Comments",
                newName: "Postetbyid");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_Postetbypersonid",
                table: "Comments",
                newName: "IX_Comments_Postetbyid");

            migrationBuilder.AddColumn<DateTime>(
                name: "PostDate",
                table: "PostImages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PostedBy",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_Postetbyid",
                table: "Comments",
                column: "Postetbyid",
                principalTable: "People",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
