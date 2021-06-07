using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 59, 41, 456, DateTimeKind.Unspecified).AddTicks(647), new TimeSpan(0, 2, 0, 0, 0)));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8925a88e-54c9-45de-886f-93a3dbbf12aa", null, "6e9eb64c-1ea6-4b9d-b3ca-e6ae117e3063" });

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9c816c3-ee96-473b-9def-a965f40da8ba", null, "9f988b94-5545-4c4a-887f-a08ce5895ca8" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -110,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3865), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -109,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3838), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -108,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3812), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -107,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3785), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -106,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3759), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -105,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3733), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -104,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3706), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -103,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3679), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -102,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3645), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -101,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3619), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -100,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3543), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -99,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3516), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -98,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3490), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -97,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3463), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -96,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3437), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -95,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3411), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -94,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3384), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -93,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3331), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -92,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3305), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -91,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3278), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -90,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -89,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3165), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -88,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3139), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -87,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3113), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -86,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3086), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -85,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -84,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -83,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -82,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2981), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -81,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2955), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -80,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2879), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -79,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2852), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -78,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2825), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -77,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2799), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -76,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2771), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -75,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2733), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -74,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2707), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -73,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2681), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -72,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2654), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -71,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2627), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -70,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2549), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -69,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2523), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -68,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2497), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -67,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2470), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -66,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2444), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -65,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2418), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -64,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2391), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -63,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2356), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -62,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -61,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2302), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -60,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2225), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -59,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2199), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -58,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2172), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -57,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2146), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -56,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2120), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -55,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2094), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -54,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2068), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -53,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2041), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -52,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2015), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -51,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1987), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -50,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1898), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -49,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1871), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -48,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1845), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -47,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1818), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -46,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1792), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -45,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1765), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -44,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -43,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1709), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -42,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1683), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -41,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -40,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -39,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1552), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -38,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1525), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -37,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1491), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -36,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -35,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1438), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -34,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -33,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1385), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -32,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1359), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -31,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -30,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1255), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -29,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1228), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -28,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1201), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -27,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1172), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -26,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1146), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -25,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1120), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -24,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1092), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -23,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1051), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -22,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1024), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -21,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(996), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -20,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(886), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -19,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(857), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -18,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(829), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -17,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(802), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -16,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -15,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(738), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -14,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(709), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -13,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(678), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -12,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Messages",
                keyColumn: "Id",
                keyValue: -11,
                column: "DateOfSending",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 225, DateTimeKind.Unspecified).AddTicks(9373), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -10,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(3225), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -8,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2904), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2575), new TimeSpan(0, 2, 0, 0, 0)), "tag0" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(2251), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 2, 0, 0, 0)), "tag2" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1605), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -3,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(1280), new TimeSpan(0, 2, 0, 0, 0)));

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "CreatedAt", "Tags" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 226, DateTimeKind.Unspecified).AddTicks(923), new TimeSpan(0, 2, 0, 0, 0)), "tag1" });

            migrationBuilder.UpdateData(
                schema: "Topicly",
                table: "Topics",
                keyColumn: "Id",
                keyValue: -1,
                column: "CreatedAt",
                value: new DateTimeOffset(new DateTime(2021, 6, 7, 15, 56, 11, 220, DateTimeKind.Unspecified).AddTicks(3374), new TimeSpan(0, 2, 0, 0, 0)));
        }
    }
}
