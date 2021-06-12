using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChatActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                schema: "Topicly",
                table: "Chats",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastActivity",
                schema: "Topicly",
                table: "Chats",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8be5c01c-44da-42fe-83fb-650c6afb637c", "AQAAAAEAACcQAAAAELLI0mUcynlXkk0krQgj4DBRnIQ/JrcnreGxHTTjgk2w/7OmNmomlA5AI2LYp2dTlQ==", "281de418-06c4-43ed-a3a3-edfd9fc23d91" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3090644e-02e4-4425-9229-0cfa77a65ef9", "AQAAAAEAACcQAAAAEIc1kMpGb+Y74jeF1MEvPgCHQXjgIH/P1Qge3SVshLSJNCKpwgH+lXq1PZ1YrNReWg==", "6a33fd14-72cc-4996-a931-a99daa853983" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -9,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5596), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5245), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -7,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4895), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -6,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4548), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4207), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3853), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -2,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 548, DateTimeKind.Unspecified).AddTicks(7956), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6249), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6221), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6193), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6166), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6138), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6110), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6082), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6054), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(6025), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5995), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5901), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5845), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5817), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5761), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5732), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5626), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5534), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5495), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5468), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5440), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5412), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5384), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5356), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5301), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5185), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5157), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5128), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5100), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5072), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5034), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5006), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4978), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4951), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4923), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4834), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4807), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4723), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4695), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4667), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4632), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4604), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4576), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4488), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4461), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4432), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4405), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4377), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4349), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4321), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4294), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4238), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4134), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4078), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4022), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3994), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3966), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3936), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3908), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3880), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3793), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3764), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3728), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3701), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3672), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3643), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3614), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3581), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3553), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3524), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3398), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3369), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3338), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3241), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3183), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3154), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3027), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2995), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2965), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2935), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2864), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2831), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2791), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(2729), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(1528), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5929), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5562), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(5214), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4863), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4517), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3821), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3455), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 549, DateTimeKind.Unspecified).AddTicks(3066), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 12, 16, 17, 29, 543, DateTimeKind.Unspecified).AddTicks(2298), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "LastActivity",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16c8b42f-b77e-4e70-90ff-552cf5477c4e", "AQAAAAEAACcQAAAAEBLKTxGGOx29wlr9DZ/kT1UClmMnekOOY/AkEwlWOO5VxwLZgNYK2ZnuPH4mxmEZpw==", "3bc9d145-3648-43e8-ae1e-b93a0b9a33fa" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f03b4875-3ac4-4d25-855e-0e9b8e3a40d6", "AQAAAAEAACcQAAAAEM3LjK/Iv5h36hBr0qoalEcnOk4NCMjofIPQrckF7A/g330WTksPfU6GvQARKcUbxg==", "b5ab7411-e238-46b7-a1cc-503554a72029" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5501), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5466), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5430), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5360), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5289), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5218), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5181), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5067), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4961), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4926), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4890), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4855), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4791), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4756), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4718), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4615), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4579), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4534), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4499), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4463), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4428), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4393), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4357), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4322), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4284), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4114), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4079), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4042), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3995), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3959), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3924), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3888), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3851), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3752), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3681), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3646), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3610), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3575), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3539), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3504), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3460), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3422), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3324), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3288), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3253), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3218), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3182), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3147), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3041), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2887), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2817), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2746), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2711), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2675), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2636), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2601), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2563), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2427), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2274), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2236), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2162), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2123), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2017), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1981), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1945), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1906), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1869), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1833), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1790), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1729), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1693), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1655), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1519), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1478), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1442), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1404), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1313), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1226), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1145), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 581, DateTimeKind.Unspecified).AddTicks(9673), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4649), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4219), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3786), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2931), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 574, DateTimeKind.Unspecified).AddTicks(8406), new TimeSpan(0, 2, 0, 0, 0)), "tag0" });
        }
    }
}
