using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Added_ChatsParticipants_And_TopicsCandidates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ChatId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "TopicAnswerer",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicCreator",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                schema: "Topicly",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                schema: "Topicly",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateTable(
                name: "ChatsParticipants",
                schema: "Topicly",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatsParticipants", x => new { x.ChatId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChatsParticipants_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatsParticipants_Chats_ChatId",
                        column: x => x.ChatId,
                        principalSchema: "Topicly",
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopicsCandidates",
                schema: "Topicly",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicsCandidates", x => new { x.TopicId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TopicsCandidates_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicsCandidates_Topics_TopicId",
                        column: x => x.TopicId,
                        principalSchema: "Topicly",
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                schema: "Topicly",
                table: "Messages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatsParticipants_UserId",
                schema: "Topicly",
                table: "ChatsParticipants",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicsCandidates_UserId",
                schema: "Topicly",
                table: "TopicsCandidates",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                schema: "Topicly",
                table: "Messages",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "ChatsParticipants",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "TopicsCandidates",
                schema: "Topicly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                schema: "Topicly",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicAnswerer",
                schema: "Topicly",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicCreator",
                schema: "Topicly",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                schema: "Topicly",
                table: "Messages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                schema: "Topicly",
                table: "Messages",
                column: "ChatId");
        }
    }
}
