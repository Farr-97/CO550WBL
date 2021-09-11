using Microsoft.EntityFrameworkCore.Migrations;

namespace Voogle.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Video_VideoID",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Video_Request_RequestID",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Video_RequestID",
                table: "Video");

            migrationBuilder.DropIndex(
                name: "IX_Comment_VideoID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "RequestID",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Request");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_VideoID",
                table: "Feedback",
                column: "VideoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedback_Video_VideoID",
                table: "Feedback",
                column: "VideoID",
                principalTable: "Video",
                principalColumn: "VideoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedback_Video_VideoID",
                table: "Feedback");

            migrationBuilder.DropIndex(
                name: "IX_Feedback_VideoID",
                table: "Feedback");

            migrationBuilder.AddColumn<int>(
                name: "RequestID",
                table: "Video",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Video_RequestID",
                table: "Video",
                column: "RequestID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_VideoID",
                table: "Comment",
                column: "VideoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Video_VideoID",
                table: "Comment",
                column: "VideoID",
                principalTable: "Video",
                principalColumn: "VideoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Video_Request_RequestID",
                table: "Video",
                column: "RequestID",
                principalTable: "Request",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
