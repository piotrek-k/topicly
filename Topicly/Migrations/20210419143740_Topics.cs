using Microsoft.EntityFrameworkCore.Migrations;

namespace Topicly.Migrations
{
    public partial class Topics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicAnswerer",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicCreator",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Chats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chats_TopicId",
                table: "Chats",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Topics_TopicId",
                table: "Chats",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Topics_TopicId",
                table: "Chats");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Chats_TopicId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicAnswerer",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicCreator",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Chats");
        }
    }
}
