using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddedChatsSeenFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AnswererSeen",
                schema: "Topicly",
                table: "Chats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CreatorSeen",
                schema: "Topicly",
                table: "Chats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswererSeen",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "CreatorSeen",
                schema: "Topicly",
                table: "Chats");
        }
    }
}
