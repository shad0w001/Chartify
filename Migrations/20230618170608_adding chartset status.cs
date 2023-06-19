using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class addingchartsetstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ChartSets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f5013bd9-a06a-4ef7-9963-259fe85907cd", "35113748-0b3e-4065-82f8-b6aa18b3a1d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49525b50-2ab5-4b25-a9d4-74c12cc1cce6", "72ff2f21-e758-45b1-94e4-996f0d764f72" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72ae6f06-922b-421d-b03f-b47756865b53", "abd139c8-5684-4ed5-9482-469ed6bcb1de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace8095e-6a00-4cf1-89bf-158d31131711", "f6b67dce-b44e-4196-ba51-87d13b6f9a13" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49525b50-2ab5-4b25-a9d4-74c12cc1cce6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72ae6f06-922b-421d-b03f-b47756865b53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ace8095e-6a00-4cf1-89bf-158d31131711");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5013bd9-a06a-4ef7-9963-259fe85907cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35113748-0b3e-4065-82f8-b6aa18b3a1d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72ff2f21-e758-45b1-94e4-996f0d764f72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abd139c8-5684-4ed5-9482-469ed6bcb1de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6b67dce-b44e-4196-ba51-87d13b6f9a13");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ChartSets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "048a4e23-cd70-4fd3-ab64-fd6a782fc41d", "c6aaa192-d78a-4a71-a7da-342a694d4e82", "Mapper", "MAPPER" },
                    { "385a7482-b3d9-4e9c-a60e-16ac224c3e5d", "2be584b5-60a9-4aa9-87c2-91509d40800e", "Admin", "ADMIN" },
                    { "4d008769-34be-474c-89a8-44be59a37497", "75e287c9-7d1c-495b-a025-0528a47b7877", "User", "USER" },
                    { "cd1096bd-9458-4d15-8e32-66420d9d7d36", "61b9377f-801b-44a5-9b01-59132362f3c9", "Featured Artist", "FEATURED ARTIST" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "57bf7688-2ebd-47d2-9eca-d1d029115b03", 0, "35a3860b-5937-406c-95f6-bc15b1547acf", new DateTime(2023, 6, 18, 19, 0, 54, 259, DateTimeKind.Local).AddTicks(8800), "fa@arist.com", true, new DateTime(2023, 6, 18, 19, 0, 54, 259, DateTimeKind.Local).AddTicks(8806), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAEOq0BcGjl3LLTs77YybbQIt6yTCDzxKZ4GP4FyxORvGdG4sTk4xBoadRaxXsCx5MjQ==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "f8475907-80ed-461a-9961-a4e6ac83e806", false, "namirin" },
                    { "937b2434-e316-45c4-ad8f-212d74a5f179", 0, "9c9322be-8935-45b2-a562-bf59317a995a", new DateTime(2023, 6, 18, 19, 0, 54, 257, DateTimeKind.Local).AddTicks(5198), "a@admin.com", true, new DateTime(2023, 6, 18, 19, 0, 54, 257, DateTimeKind.Local).AddTicks(5245), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAEDoD8S2gfhlRJfLazg8+JMMuw32zfBJY9tk545yECVINPMc5zWtQvLG6y8eExWWW6A==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "5e7382b1-9bfc-49ac-80d0-4b55a9b51068", false, "shad0w" },
                    { "99ebd757-b7cf-4ab4-8acc-172c212d7528", 0, "158079af-d1b1-4bb0-b59b-5a013f1d396e", new DateTime(2023, 6, 18, 19, 0, 54, 260, DateTimeKind.Local).AddTicks(9863), "m@mapper.com", true, new DateTime(2023, 6, 18, 19, 0, 54, 260, DateTimeKind.Local).AddTicks(9866), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAEN1ydenMSFGl2dPiFiBt43SpvC10qcMi1wiQL83CvjWoQj4dydBD03J5MOUrL4Az5g==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "2d99fd6f-46d0-4047-a8e3-719187996923", false, "Sotarks" },
                    { "bdea10d4-f7a4-4895-aa26-d175e3807ff8", 0, "fa01bef0-ff1e-43a5-8af9-66793b663c81", new DateTime(2023, 6, 18, 19, 0, 54, 258, DateTimeKind.Local).AddTicks(7163), "u@user.com", true, new DateTime(2023, 6, 18, 19, 0, 54, 258, DateTimeKind.Local).AddTicks(7176), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAENR4jXhJF1CUrUgx+rjE3T6idLcvevjNqziSZ1rbVmL4xTgfeGvkUZ/aTUQ+qTWenQ==", null, false, "/Users/ProfileBanners/default.png", "/Users/ProfilePictures/default.png", "06a4322e-4cd5-44d1-a7b8-9de3f7f40064", false, "onegai" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cd1096bd-9458-4d15-8e32-66420d9d7d36", "57bf7688-2ebd-47d2-9eca-d1d029115b03" },
                    { "385a7482-b3d9-4e9c-a60e-16ac224c3e5d", "937b2434-e316-45c4-ad8f-212d74a5f179" },
                    { "048a4e23-cd70-4fd3-ab64-fd6a782fc41d", "99ebd757-b7cf-4ab4-8acc-172c212d7528" },
                    { "4d008769-34be-474c-89a8-44be59a37497", "bdea10d4-f7a4-4895-aa26-d175e3807ff8" }
                });
        }
    }
}
