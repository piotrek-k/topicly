using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ExpiryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpiryDate",
                schema: "Topicly",
                table: "Topics",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                column: "ExpiryDate",
                value: new DateTimeOffset(new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryDate",
                schema: "Topicly",
                table: "Topics");
        }
    }
}
