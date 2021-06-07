using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ProposeNext_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Topicly",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                schema: "Topicly",
                table: "Topics",
                type: "nvarchar(450)",
                nullable: true);

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
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(5101), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4649), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(4219), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3786), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(3357), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2931), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(2053), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "CreatedById" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 582, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "CreatedById", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 22, 41, 24, 574, DateTimeKind.Unspecified).AddTicks(8406), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag0" });

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CreatedById",
                schema: "Topicly",
                table: "Topics",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_AspNetUsers_CreatedById",
                schema: "Topicly",
                table: "Topics",
                column: "CreatedById",
                principalSchema: "Identity",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_AspNetUsers_CreatedById",
                schema: "Topicly",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_CreatedById",
                schema: "Topicly",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                schema: "Topicly",
                table: "Topics");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "Topicly",
                table: "Topics",
                type: "nvarchar(max)",
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
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3931), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(3496), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2932), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2492), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(2110), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1675), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "tag3" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(1227), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 136, DateTimeKind.Unspecified).AddTicks(702), new TimeSpan(0, 2, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "CreatedAt", "CreatedBy", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 16, 20, 21, 129, DateTimeKind.Unspecified).AddTicks(2780), new TimeSpan(0, 2, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "tag2" });
        }
    }
}
