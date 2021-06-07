using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Message_colums_modif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicAnswerer",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicCreator",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                schema: "Topicly",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicAnswererId",
                schema: "Topicly",
                table: "Chats",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TopicCreatorId",
                schema: "Topicly",
                table: "Chats",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70fbb3fc-d7f6-4382-9349-5cac37e75682", "AQAAAAEAACcQAAAAEJvvtrV40+MVB5YBg+Fx5mIqMPnWyw7TcExuAOYJdchnz+FIY4zeK26ZN4AIR+QhMQ==", "33d511eb-a500-4131-9738-0223a4d5410f" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbf94366-19a1-4041-bbef-39243ba92a07", "AQAAAAEAACcQAAAAECMFqckmlKazDSMMcW/D8AX99L2+Re9VCJD+cco+VBFyMNqHRUq98nHs2eZ07bv0gA==", "5858738b-6afb-408c-915c-3b0937bb171d" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "TopicAnswererId", "TopicCreatorId" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4775), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4743), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4711), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4680), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4617), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4585), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4554), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4522), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4489), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4321), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4289), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4257), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4224), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4192), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4160), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4059), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4028), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3996), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3901), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3870), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3834), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3750), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3718), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3686), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3654), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3622), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3591), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3558), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3465), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3432), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3400), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3123), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3091), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3059), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3026), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2901), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2805), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2774), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2740), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2708), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2676), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2551), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2463), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2430), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2399), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2367), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2336), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2304), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2273), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2241), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2210), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2076), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1996), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1964), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1933), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1900), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1868), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1836), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1802), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1770), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1738), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1645), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1613), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1580), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1543), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1391), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1359), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1326), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1196), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1164), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1132), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1064), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1032), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1001), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(953), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(821), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(789), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(656), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(587), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(552), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(519), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(477), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(444), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(407), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(330), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 135, DateTimeKind.Unspecified).AddTicks(8885), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1675), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1227), new TimeSpan(0, 2, 0, 0, 0)), "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(702), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 129, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                schema: "Topicly",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_TopicAnswererId",
                schema: "Topicly",
                table: "Chats",
                column: "TopicAnswererId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_TopicCreatorId",
                schema: "Topicly",
                table: "Chats",
                column: "TopicCreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_AspNetUsers_TopicAnswererId",
                schema: "Topicly",
                table: "Chats",
                column: "TopicAnswererId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_AspNetUsers_TopicCreatorId",
                schema: "Topicly",
                table: "Chats",
                column: "TopicCreatorId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                schema: "Topicly",
                table: "Messages",
                column: "SenderId",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_AspNetUsers_TopicAnswererId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Chats_AspNetUsers_TopicCreatorId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_SenderId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_SenderId",
                schema: "Topicly",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Chats_TopicAnswererId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_TopicCreatorId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicAnswererId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "TopicCreatorId",
                schema: "Topicly",
                table: "Chats");

            migrationBuilder.AlterColumn<string>(
                name: "SenderId",
                schema: "Topicly",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae2af2eb-915f-4f28-a8b9-1af728ce4c0d", "AQAAAAEAACcQAAAAECUs9c9M1urZRg/BLjluPTALuUGurDu6MCuL2SeZli6vh2ROflWmxuzb1jQQd2ig+g==", "54232939-1091-485d-8c3b-aed3c4991933" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e842d1cd-7ed9-4763-b46d-2cc89a9fcd11", "AQAAAAEAACcQAAAAECOLJmflT1ZahWptTeR8G3am9xWlAnk7C8wLDU0O01ImFpSPSvylUYGniY584K/k0w==", "704f96c1-43f1-4ea8-9a54-060494d6fe9d" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Chats",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "TopicAnswerer", "TopicCreator" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3765), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3714), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3689), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3663), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3637), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3612), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3586), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3420), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3394), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3368), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3342), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3317), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3291), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3265), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3214), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3189), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3164), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3062), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2888), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2837), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2786), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2716), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2690), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2665), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2640), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2614), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2587), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2557), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2490), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2465), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2440), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2370), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2345), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2270), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2244), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2219), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2194), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2168), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2142), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2025), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2000), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1975), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1751), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1723), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1694), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1606), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1576), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1351), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1324), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1267), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1236), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1208), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1179), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1098), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1069), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1041), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1012), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(984), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(955), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(815), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(748), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(723), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(697), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(623), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(598), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(573), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(545), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(520), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(495), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(469), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(444), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(419), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(391), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(206), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(177), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(151), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(125), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(66), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(38), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(7), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 455, DateTimeKind.Unspecified).AddTicks(9955), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 455, DateTimeKind.Unspecified).AddTicks(8687), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3486), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(3112), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2739), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2394), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(2048), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1634), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(1125), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(647), new TimeSpan(0, 2, 0, 0, 0)), "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(240), new TimeSpan(0, 2, 0, 0, 0)), "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 450, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
