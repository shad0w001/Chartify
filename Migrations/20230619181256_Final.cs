using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Charts");

            migrationBuilder.AddColumn<int>(
                name: "BPM",
                table: "ChartSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "ChartSets",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c83e2594-3c81-4ed5-a7c2-0f962dcf1df7", "36cfc697-e6d8-49ca-b9e1-1121db8043be" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aefaf4f0-6f84-4d6a-8ae4-6a5e8deddf54", "78fac25b-75f0-4f8d-880f-c756a8464762" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e217304-0938-4a44-9c64-da2551cc359d", "87009f77-b262-4a27-abdb-78df6bd4f480" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddd77c4d-718e-4305-bff5-7017fc2c29a4", "d8a93562-93e8-4a00-9b42-e9401f01af83" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e217304-0938-4a44-9c64-da2551cc359d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aefaf4f0-6f84-4d6a-8ae4-6a5e8deddf54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c83e2594-3c81-4ed5-a7c2-0f962dcf1df7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddd77c4d-718e-4305-bff5-7017fc2c29a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36cfc697-e6d8-49ca-b9e1-1121db8043be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78fac25b-75f0-4f8d-880f-c756a8464762");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87009f77-b262-4a27-abdb-78df6bd4f480");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8a93562-93e8-4a00-9b42-e9401f01af83");

            migrationBuilder.DropColumn(
                name: "BPM",
                table: "ChartSets");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ChartSets");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Duration",
                table: "Charts",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49525b50-2ab5-4b25-a9d4-74c12cc1cce6", "5f4ee9ef-d3c7-4539-9a91-35971e41b7cc", "Mapper", "MAPPER" },
                    { "72ae6f06-922b-421d-b03f-b47756865b53", "6caeb0ba-b292-4ac8-8862-b4d65debd405", "Featured Artist", "FEATURED ARTIST" },
                    { "ace8095e-6a00-4cf1-89bf-158d31131711", "8a4da5e6-7aaa-4dba-b96c-09da435b1758", "Admin", "ADMIN" },
                    { "f5013bd9-a06a-4ef7-9963-259fe85907cd", "b8991653-b8d5-42a7-81a8-c484efff51fa", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "35113748-0b3e-4065-82f8-b6aa18b3a1d4", 0, "7e4edcfa-5f88-497d-8d15-b4eabe10a99c", new DateTime(2023, 6, 18, 20, 6, 8, 140, DateTimeKind.Local).AddTicks(1346), "u@user.com", true, new DateTime(2023, 6, 18, 20, 6, 8, 140, DateTimeKind.Local).AddTicks(1349), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAEDeqHw2WH8GrZ0rwn4/aufM+GRDW3PjY++ddFs3ScyS9hkeNqkftCab9eEXQnmiGew==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "674af4d2-9d9e-468f-b0ed-a7db2d89d2bd", false, "onegai" },
                    { "72ff2f21-e758-45b1-94e4-996f0d764f72", 0, "1a6fa8df-c31f-42b5-ba60-2193e13306d6", new DateTime(2023, 6, 18, 20, 6, 8, 142, DateTimeKind.Local).AddTicks(4252), "m@mapper.com", true, new DateTime(2023, 6, 18, 20, 6, 8, 142, DateTimeKind.Local).AddTicks(4254), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAEAhQoPA5JfQjLMNU9gMON9TFbRHJq88/Q8LAr2FyyLlKlqMn1J/WFnWolRb+hV7Nwg==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "f1cc1dcc-baac-42d4-8d79-79bcb7ccf2b0", false, "Sotarks" },
                    { "abd139c8-5684-4ed5-9482-469ed6bcb1de", 0, "b782c2f9-1ce5-44d0-85dd-50f7a1a115ac", new DateTime(2023, 6, 18, 20, 6, 8, 141, DateTimeKind.Local).AddTicks(2736), "fa@arist.com", true, new DateTime(2023, 6, 18, 20, 6, 8, 141, DateTimeKind.Local).AddTicks(2738), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAEN/7uMx70LauLKY7kNDBU5StaIjSOIbeCCwHmaTYsgFmyzW0E2dWclCn4ZUTF/DZqw==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "4c48c11d-7551-4da8-a262-ec0ec82846e1", false, "namirin" },
                    { "f6b67dce-b44e-4196-ba51-87d13b6f9a13", 0, "2ac36bb9-c5b0-4053-ba97-124bb80084c2", new DateTime(2023, 6, 18, 20, 6, 8, 138, DateTimeKind.Local).AddTicks(9561), "a@admin.com", true, new DateTime(2023, 6, 18, 20, 6, 8, 138, DateTimeKind.Local).AddTicks(9593), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAENVSsSnAzlZu7jmI4ZoQXv2yhnJ4gp9mDm3CNKhUStBAb+0FAkd/A0u4bVphT0Bysw==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "a0a713c2-6be1-4d31-a7b1-63592e0e340c", false, "shad0w" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f5013bd9-a06a-4ef7-9963-259fe85907cd", "35113748-0b3e-4065-82f8-b6aa18b3a1d4" },
                    { "49525b50-2ab5-4b25-a9d4-74c12cc1cce6", "72ff2f21-e758-45b1-94e4-996f0d764f72" },
                    { "72ae6f06-922b-421d-b03f-b47756865b53", "abd139c8-5684-4ed5-9482-469ed6bcb1de" },
                    { "ace8095e-6a00-4cf1-89bf-158d31131711", "f6b67dce-b44e-4196-ba51-87d13b6f9a13" }
                });
        }
    }
}
