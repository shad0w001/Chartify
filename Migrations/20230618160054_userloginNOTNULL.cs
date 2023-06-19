using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class userloginNOTNULL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cd1096bd-9458-4d15-8e32-66420d9d7d36", "57bf7688-2ebd-47d2-9eca-d1d029115b03" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "385a7482-b3d9-4e9c-a60e-16ac224c3e5d", "937b2434-e316-45c4-ad8f-212d74a5f179" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "048a4e23-cd70-4fd3-ab64-fd6a782fc41d", "99ebd757-b7cf-4ab4-8acc-172c212d7528" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d008769-34be-474c-89a8-44be59a37497", "bdea10d4-f7a4-4895-aa26-d175e3807ff8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "048a4e23-cd70-4fd3-ab64-fd6a782fc41d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "385a7482-b3d9-4e9c-a60e-16ac224c3e5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d008769-34be-474c-89a8-44be59a37497");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd1096bd-9458-4d15-8e32-66420d9d7d36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57bf7688-2ebd-47d2-9eca-d1d029115b03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "937b2434-e316-45c4-ad8f-212d74a5f179");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99ebd757-b7cf-4ab4-8acc-172c212d7528");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdea10d4-f7a4-4895-aa26-d175e3807ff8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastLoginDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28a567b9-3a28-4dfa-b7c6-6f02dc9ef8aa", "9962fdba-3dd4-4a4d-bc41-c0c89a6da813", "Mapper", "MAPPER" },
                    { "b0e64335-3e65-4597-afe2-0273a4d565d8", "f303de62-2e1d-4c48-8a98-969bfe3f733b", "User", "USER" },
                    { "c2430274-97bb-41e7-a903-34dbb277d5cb", "bcff66a1-4875-4a0e-9c82-9883da09137d", "Featured Artist", "FEATURED ARTIST" },
                    { "ff2019eb-f2f0-4eff-a48a-384d9a7be8ee", "91ef000c-d511-4784-9efa-c143f8877009", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "017c5448-26cd-4727-81b0-50d22b312372", 0, "e7638366-cf92-4ef6-946b-abcd7ba9ac1c", new DateTime(2023, 6, 15, 20, 21, 15, 540, DateTimeKind.Local).AddTicks(7055), "a@admin.com", true, new DateTime(2023, 6, 15, 20, 21, 15, 540, DateTimeKind.Local).AddTicks(7095), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAENS3gmW6cpFv5tUxcuSXkvpKkhEFOv5yNlyxAEJThEW7K56PSoe7PFmX+wNipYAGzg==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "48814cb9-7029-4e9d-9867-e0ee6bb5263c", false, "shad0w" },
                    { "a330f7ca-4fd8-4a49-90a8-e2d8847d944c", 0, "1c91afd2-f04a-4af4-ac11-19242cd069f1", new DateTime(2023, 6, 15, 20, 21, 15, 547, DateTimeKind.Local).AddTicks(6865), "m@mapper.com", true, new DateTime(2023, 6, 15, 20, 21, 15, 547, DateTimeKind.Local).AddTicks(6870), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAEIQxuRTXxs/Dm+v0bMLJDwRekA0O6L3ruxTIkv/8qYZLbvjsY61xzL1rvwPxyy9efg==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "4d0acc6e-e98c-4c4e-ad82-57e9d72f7063", false, "Sotarks" },
                    { "eab27330-cea8-41ea-8b0b-4dd18792a304", 0, "709ff970-c1dd-4ef0-973c-c54eb209fa86", new DateTime(2023, 6, 15, 20, 21, 15, 543, DateTimeKind.Local).AddTicks(225), "u@user.com", true, new DateTime(2023, 6, 15, 20, 21, 15, 543, DateTimeKind.Local).AddTicks(230), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAEH+80JNoj9CygM8k9rPUL8OUUrvoU915WvR4spEIoPxyfSI9PzCoxukOdr/vgzC8+Q==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "6e7e4242-da85-49ea-9b60-ef1d18ff956f", false, "onegai" },
                    { "ed14f34b-d1bc-4f05-8ff8-90514f3393bc", 0, "235d9a17-fc49-48fa-9308-9d6210d3d1bd", new DateTime(2023, 6, 15, 20, 21, 15, 545, DateTimeKind.Local).AddTicks(3724), "fa@arist.com", true, new DateTime(2023, 6, 15, 20, 21, 15, 545, DateTimeKind.Local).AddTicks(3729), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAENXnr9JKe4TH3SlEFP+M+nt129HDJcRIxPg1FmwdpUp9gtiwtKq5gPrhD0jPoSiL7w==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "2a491a6e-42b3-4545-92a7-372cda492a69", false, "namirin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ff2019eb-f2f0-4eff-a48a-384d9a7be8ee", "017c5448-26cd-4727-81b0-50d22b312372" },
                    { "28a567b9-3a28-4dfa-b7c6-6f02dc9ef8aa", "a330f7ca-4fd8-4a49-90a8-e2d8847d944c" },
                    { "b0e64335-3e65-4597-afe2-0273a4d565d8", "eab27330-cea8-41ea-8b0b-4dd18792a304" },
                    { "c2430274-97bb-41e7-a903-34dbb277d5cb", "ed14f34b-d1bc-4f05-8ff8-90514f3393bc" }
                });
        }
    }
}
