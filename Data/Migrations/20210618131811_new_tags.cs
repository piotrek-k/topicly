using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class new_tags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                schema: "Topicly",
                table: "Topics");

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopicTag",
                schema: "Topicly",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicTag", x => new { x.TopicId, x.TagId });
                    table.ForeignKey(
                        name: "FK_TopicTag_Tags_TagId",
                        column: x => x.TagId,
                        principalSchema: "Topicly",
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TopicTag_Topics_TopicId",
                        column: x => x.TopicId,
                        principalSchema: "Topicly",
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -1, "tag-1" },
                    { -2, "tag-2" },
                    { -3, "tag-3" },
                    { -4, "tag-4" }
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "TopicTag",
                columns: new[] { "TagId", "TopicId" },
                values: new object[,]
                {
                    { -1, -4 },
                    { -1, -8 },
                    { -2, -3 },
                    { -2, -7 },
                    { -3, -2 },
                    { -3, -6 },
                    { -3, -10 },
                    { -4, -1 },
                    { -4, -5 },
                    { -4, -9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TopicTag_TagId",
                schema: "Topicly",
                table: "TopicTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopicTag",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "Topicly");

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                schema: "Topicly",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "Tags",
                value: "tag-2");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                column: "Tags",
                value: "tag-1");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                column: "Tags",
                value: "tag0");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                column: "Tags",
                value: "tag-3");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                column: "Tags",
                value: "tag-2");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                column: "Tags",
                value: "tag-1");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                column: "Tags",
                value: "tag0");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                column: "Tags",
                value: "tag-3");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                column: "Tags",
                value: "tag-2");

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                column: "Tags",
                value: "tag-1");
        }
    }
}
