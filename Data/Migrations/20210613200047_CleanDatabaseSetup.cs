using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CleanDatabaseSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.EnsureSchema(
                name: "Topicly");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                schema: "Identity",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                schema: "Identity",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositiveCount = table.Column<int>(type: "int", nullable: false),
                    NegativeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "Identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Identity",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "Identity",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedById = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TopicCreatorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicAnswererId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastActivity = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_TopicAnswererId",
                        column: x => x.TopicAnswererId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_AspNetUsers_TopicCreatorId",
                        column: x => x.TopicCreatorId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chats_Topics_TopicId",
                        column: x => x.TopicId,
                        principalSchema: "Topicly",
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeenByUser",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeenByUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeenByUser_Topics_TopicId",
                        column: x => x.TopicId,
                        principalSchema: "Topicly",
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                schema: "Topicly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatId = table.Column<int>(type: "int", nullable: false),
                    DateOfSending = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalSchema: "Identity",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalSchema: "Topicly",
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", 0, "5b39e64d-1f37-4273-a14b-cf96c621f2be", "bob@mail.com", false, false, null, "BOB@MAIL.COM", "BOB", "AQAAAAEAACcQAAAAEC9DL7FDwapRt+dT3rP9ABeXLOFipwhUv5WPGKJYnTdoFduEHsy7I2ajVH2ynTOHuA==", null, false, "1e7c8add-25c2-4666-8c20-88f02ff06fb6", false, "bob" });

            migrationBuilder.InsertData(
                schema: "Identity",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", 0, "6d4d777c-833a-4882-8cc2-998741d682fb", "alice@mail.com", false, false, null, "ALICE@MAIL.COM", "ALICE", "AQAAAAEAACcQAAAAEJeED9Tjrh1HWd495eES4NMzrLOZNG3whkLCv1YrYwCYXTJRaXOCUq7xEcxKW2AE+A==", null, false, "c8055658-8a3e-4321-9cf7-6b2e7d52de74", false, "alice" });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Topics",
                columns: new[] { "Id", "CreatedAt", "CreatedById", "Name", "Tags" },
                values: new object[,]
                {
                    { -2, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "TEMAT #-1", "tag-2" },
                    { -4, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "TEMAT #-3", "tag0" },
                    { -6, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "TEMAT #-5", "tag-2" },
                    { -8, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "TEMAT #-7", "tag0" },
                    { -10, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "TEMAT #-9", "tag-2" },
                    { -1, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "TEMAT #0", "tag-1" },
                    { -3, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "TEMAT #-2", "tag-3" },
                    { -5, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "TEMAT #-4", "tag-1" },
                    { -7, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "TEMAT #-6", "tag-3" },
                    { -9, new DateTimeOffset(new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "TEMAT #-8", "tag-1" }
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Chats",
                columns: new[] { "Id", "CreatedAt", "LastActivity", "TopicAnswererId", "TopicCreatorId", "TopicId" },
                values: new object[,]
                {
                    { -2, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330", -2 },
                    { -4, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330", -4 },
                    { -6, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330", -6 },
                    { -8, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330", -8 },
                    { -10, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711", "c7b013f0-5201-4317-abd8-c211f91b7330", -10 },
                    { -1, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711", -1 },
                    { -3, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711", -3 },
                    { -5, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711", -5 },
                    { -7, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711", -7 },
                    { -9, new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330", "fab4fac1-c546-41de-aebc-a14da6895711", -9 }
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "DateOfSending", "SenderId" },
                values: new object[,]
                {
                    { -21, -2, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -53, -5, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -52, -5, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -51, -5, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -40, -3, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -39, -3, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -38, -3, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -37, -3, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -36, -3, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -35, -3, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -34, -3, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -33, -3, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -32, -3, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -31, -3, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -20, -1, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -19, -1, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -18, -1, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -17, -1, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -16, -1, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -15, -1, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -14, -1, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -13, -1, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -54, -5, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -12, -1, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -55, -5, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -57, -5, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -98, -9, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -97, -9, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -96, -9, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -95, -9, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -94, -9, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -93, -9, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -92, -9, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -91, -9, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -80, -7, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -79, -7, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -78, -7, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -77, -7, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -76, -7, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -75, -7, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -74, -7, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -73, -7, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" }
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "DateOfSending", "SenderId" },
                values: new object[,]
                {
                    { -72, -7, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -71, -7, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -60, -5, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -59, -5, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -58, -5, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -56, -5, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -11, -1, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -110, -10, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -109, -10, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -62, -6, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -61, -6, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -50, -4, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -49, -4, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -48, -4, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -47, -4, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -46, -4, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -45, -4, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -44, -4, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -43, -4, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -42, -4, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -41, -4, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -30, -2, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -29, -2, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -28, -2, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -27, -2, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -26, -2, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -25, -2, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -24, -2, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -23, -2, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -22, -2, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -63, -6, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -64, -6, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -65, -6, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -66, -6, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -108, -10, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -107, -10, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -106, -10, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -105, -10, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -104, -10, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -103, -10, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -102, -10, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -101, -10, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" }
                });

            migrationBuilder.InsertData(
                schema: "Topicly",
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "DateOfSending", "SenderId" },
                values: new object[,]
                {
                    { -90, -8, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -89, -8, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -99, -9, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -88, -8, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -86, -8, "this is test message #-6", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -85, -8, "this is test message #-5", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -84, -8, "this is test message #-4", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -83, -8, "this is test message #-3", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -82, -8, "this is test message #-2", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -81, -8, "this is test message #-1", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -70, -6, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -69, -6, "this is test message #-9", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -68, -6, "this is test message #-8", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" },
                    { -67, -6, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -87, -8, "this is test message #-7", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "c7b013f0-5201-4317-abd8-c211f91b7330" },
                    { -100, -9, "this is test message #-10", new DateTimeOffset(new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "fab4fac1-c546-41de-aebc-a14da6895711" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Identity",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Identity",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Identity",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Identity",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Identity",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Identity",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Identity",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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

            migrationBuilder.CreateIndex(
                name: "IX_Chats_TopicId",
                schema: "Topicly",
                table: "Chats",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                schema: "Identity",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                schema: "Identity",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                schema: "Topicly",
                table: "Messages",
                column: "ChatId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                schema: "Topicly",
                table: "Messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                schema: "Identity",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                schema: "Identity",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                schema: "Identity",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_SeenByUser_TopicId",
                schema: "Topicly",
                table: "SeenByUser",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CreatedById",
                schema: "Topicly",
                table: "Topics",
                column: "CreatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "DeviceCodes",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Messages",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "PersistedGrants",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Reactions",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "SeenByUser",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "Identity");

            migrationBuilder.DropTable(
                name: "Chats",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "Topics",
                schema: "Topicly");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "Identity");
        }
    }
}
