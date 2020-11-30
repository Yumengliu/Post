using Microsoft.EntityFrameworkCore.Migrations;

namespace Post.Migrations
{
    public partial class Onetomany1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostResultId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "PostResultId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostResultId",
                table: "Comments",
                column: "PostResultId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostResultId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "PostResultId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostResultId",
                table: "Comments",
                column: "PostResultId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
