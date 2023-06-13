using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class Fixingupstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
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
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileBannerPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "AspNetRoleClaims",
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
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
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
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
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
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChartSets",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CoverPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PlayCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChartSets_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserUser",
                columns: table => new
                {
                    SubscribedToId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubscribersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserUser", x => new { x.SubscribedToId, x.SubscribersId });
                    table.ForeignKey(
                        name: "FK_UserUser_AspNetUsers_SubscribedToId",
                        column: x => x.SubscribedToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserUser_AspNetUsers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DifficultyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyRating = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: false),
                    ObjectCount = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChartSetId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Charts_ChartSets_ChartSetId",
                        column: x => x.ChartSetId,
                        principalTable: "ChartSets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChartsOfSets",
                columns: table => new
                {
                    ChartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChartSetId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_ChartsOfSets_Charts_ChartId",
                        column: x => x.ChartId,
                        principalTable: "Charts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChartsOfSets_ChartSets_ChartSetId",
                        column: x => x.ChartSetId,
                        principalTable: "ChartSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3cc9bbc4-50b4-4d6f-87aa-ce59b4db9901", "35892a6d-6534-4152-9b1b-efe06975fc64", "Mapper", "MAPPER" },
                    { "8b41ab70-a495-41c3-a7f3-1437c3326150", "59ad3e8a-8e9f-4a08-9f09-d4fd88ef3b35", "Admin", "ADMIN" },
                    { "979f6b9f-f0b0-49be-8683-ba7831df8e26", "2ba64e3b-4096-4229-83df-d92069580c6c", "Featured Artist", "FEATURED ARTIST" },
                    { "d92019bb-20cf-4bce-9845-35528c5e464d", "6c0ee63b-8d87-4dc1-b0f6-c1868cead2ae", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08c49b9d-3dcb-4a2d-9d4b-686d2f3f2e14", 0, "398d1cbb-374f-4af2-b767-ce5bc6708da1", new DateTime(2023, 6, 13, 20, 30, 57, 957, DateTimeKind.Local).AddTicks(876), "m@mapper.com", true, new DateTime(2023, 6, 13, 20, 30, 57, 957, DateTimeKind.Local).AddTicks(930), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAEJT3KvUMDJ4C2REkaHUJj6YPEkbVsWsZAIkhweyU9oowGhuIHgjWJxYOG/Ct9MQ5XQ==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "b122e5d2-311e-4e61-9fe1-7c9f8931071b", false, "Sotarks" },
                    { "29b7ff78-c5f4-4015-a0b7-ec8cf5f533c8", 0, "76612f4a-680d-46c1-93fa-e34b45f22d59", new DateTime(2023, 6, 13, 20, 30, 57, 954, DateTimeKind.Local).AddTicks(1550), "fa@arist.com", true, new DateTime(2023, 6, 13, 20, 30, 57, 954, DateTimeKind.Local).AddTicks(1602), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAEDJ23340mLJQtneib0mfp4lRoQcH20hNkJRmu40NZLArxhevEt70pwtCb3Fe5sv+mg==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "ded40d02-502d-414f-9d59-cc163b72f5e5", false, "namirin" },
                    { "4ee98ffa-0281-4866-a596-02579bb828dd", 0, "c46135cd-eeb3-4b47-a74b-8d77ffb5f0bf", new DateTime(2023, 6, 13, 20, 30, 57, 947, DateTimeKind.Local).AddTicks(4375), "a@admin.com", true, new DateTime(2023, 6, 13, 20, 30, 57, 947, DateTimeKind.Local).AddTicks(4422), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAEOCYnbDBSF7mtBAOC3S3LQAA/Yqnym419S3byXsO0XLNwrN+BlQoUBaeVeOfGmvQZw==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "afa509a4-24ca-4ece-99f0-582968ff21e9", false, "shad0w" },
                    { "7b52428e-de63-4ecc-b961-4f69dfc84774", 0, "312779f3-189a-4891-8e2a-c2d26d6a6d42", new DateTime(2023, 6, 13, 20, 30, 57, 951, DateTimeKind.Local).AddTicks(1501), "u@user.com", true, new DateTime(2023, 6, 13, 20, 30, 57, 951, DateTimeKind.Local).AddTicks(1565), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAEBT6idZPV8M2oTD2wi1b0RXk1FGhUQZPkwoYGo7mtSOSaenskQlVbZoWcdVbY28GHg==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "1d232201-ad16-41bb-9886-848069789fa3", false, "onegai" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3cc9bbc4-50b4-4d6f-87aa-ce59b4db9901", "08c49b9d-3dcb-4a2d-9d4b-686d2f3f2e14" },
                    { "979f6b9f-f0b0-49be-8683-ba7831df8e26", "29b7ff78-c5f4-4015-a0b7-ec8cf5f533c8" },
                    { "8b41ab70-a495-41c3-a7f3-1437c3326150", "4ee98ffa-0281-4866-a596-02579bb828dd" },
                    { "d92019bb-20cf-4bce-9845-35528c5e464d", "7b52428e-de63-4ecc-b961-4f69dfc84774" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Charts_ChartSetId",
                table: "Charts",
                column: "ChartSetId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartSets_CreatorId",
                table: "ChartSets",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartsOfSets_ChartId",
                table: "ChartsOfSets",
                column: "ChartId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartsOfSets_ChartSetId",
                table: "ChartsOfSets",
                column: "ChartSetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserUser_SubscribersId",
                table: "UserUser",
                column: "SubscribersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChartsOfSets");

            migrationBuilder.DropTable(
                name: "UserUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropTable(
                name: "ChartSets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
