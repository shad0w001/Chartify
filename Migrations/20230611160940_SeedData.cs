using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26c07908-50cd-4793-a6d0-18c8a2a6a2c2", "1cbb1dd3-c7c3-4ced-ad15-ca16820e45ab", "User", "USER" },
                    { "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9", "fc6519f9-3e05-415b-ae93-beca32708783", "Mapper", "MAPPER" },
                    { "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be", "74f23d4b-7d22-4f46-a45d-79ee636e2b51", "Featured Artist", "FEATURED ARTIST" },
                    { "e148eee7-c102-43ad-b30d-df6bbc7b7052", "bb6fe8f8-b302-431f-9d6e-370d9ae347f7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6f03229f-09ac-4d92-9b08-5fe517eb08b6", 0, "de41b399-ee1f-490d-9b65-d073a5b40e22", new DateTime(2023, 6, 11, 19, 9, 39, 903, DateTimeKind.Local).AddTicks(446), "a@admin.com", true, new DateTime(2023, 6, 11, 19, 9, 39, 903, DateTimeKind.Local).AddTicks(486), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAEG9hHAX2k2JDTalu5pBuXVQ2Ys6UI4nvQ4LSt+ZfJfJzGVKqkF9N2Nx1+wuFkK3v7Q==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "d6a58a2f-d5db-4e4f-9b9e-a8f1af6b92bf", false, "shad0w" },
                    { "774604b1-c0a9-4198-89d1-48979fe430cc", 0, "d0131c0d-ac9c-4605-95e6-a55656a66f0c", new DateTime(2023, 6, 11, 19, 9, 39, 907, DateTimeKind.Local).AddTicks(239), "m@mapper.com", true, new DateTime(2023, 6, 11, 19, 9, 39, 907, DateTimeKind.Local).AddTicks(273), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAENDi8in0i5kxroT3/sTL1/v/AnwLGD3tkcnFiorbd4eNZwjf2ytHkfyZ3yvS70jiDg==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "53521370-35f7-4357-9516-8322a1e2e39a", false, "Sotarks" },
                    { "8b08ade8-07f0-462b-9362-eaf2606dd1a7", 0, "52e4e53b-bb6c-4215-a0fa-c88a67d4c5f6", new DateTime(2023, 6, 11, 19, 9, 39, 904, DateTimeKind.Local).AddTicks(2774), "u@user.com", true, new DateTime(2023, 6, 11, 19, 9, 39, 904, DateTimeKind.Local).AddTicks(2787), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAEG9N8EK+G03HXVltf8JxcFwr8YSOXHtxUazWw6QZHa7P+ur9F8azkX1iqeDPJwTY3Q==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "70e12d93-ded9-4ecd-9cc8-f5fd9e9c92aa", false, "onegai" },
                    { "c717dfd9-74e3-4f70-9ec7-dfca8e5be297", 0, "89a78146-2f79-416d-aad3-bc08a61c6543", new DateTime(2023, 6, 11, 19, 9, 39, 905, DateTimeKind.Local).AddTicks(5946), "fa@arist.com", true, new DateTime(2023, 6, 11, 19, 9, 39, 905, DateTimeKind.Local).AddTicks(5999), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAELJGKiBT3YQoXZHLZKUeiuEObR9GjCT6sjTCO57Q62U9h1oqmALzg+Nk+nAiYwN2Sg==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "bf523c49-da87-478c-8c51-e321c95535bc", false, "namirin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e148eee7-c102-43ad-b30d-df6bbc7b7052", "6f03229f-09ac-4d92-9b08-5fe517eb08b6" },
                    { "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9", "774604b1-c0a9-4198-89d1-48979fe430cc" },
                    { "26c07908-50cd-4793-a6d0-18c8a2a6a2c2", "8b08ade8-07f0-462b-9362-eaf2606dd1a7" },
                    { "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be", "c717dfd9-74e3-4f70-9ec7-dfca8e5be297" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e148eee7-c102-43ad-b30d-df6bbc7b7052", "6f03229f-09ac-4d92-9b08-5fe517eb08b6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9", "774604b1-c0a9-4198-89d1-48979fe430cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26c07908-50cd-4793-a6d0-18c8a2a6a2c2", "8b08ade8-07f0-462b-9362-eaf2606dd1a7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be", "c717dfd9-74e3-4f70-9ec7-dfca8e5be297" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26c07908-50cd-4793-a6d0-18c8a2a6a2c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e148eee7-c102-43ad-b30d-df6bbc7b7052");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f03229f-09ac-4d92-9b08-5fe517eb08b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "774604b1-c0a9-4198-89d1-48979fe430cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b08ade8-07f0-462b-9362-eaf2606dd1a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c717dfd9-74e3-4f70-9ec7-dfca8e5be297");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
