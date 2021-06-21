using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedChatDeletion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AnswererDeleted",
                schema: "Topicly",
                table: "Chats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CreatorDeleted",
                schema: "Topicly",
                table: "Chats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswererDeleted",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "CreatorDeleted",
                schema: "Topicly",
                table: "Chats");
        }
    }
}
