using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chartify.Migrations
{
    public partial class RemovedpointlessStatusproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3cc9bbc4-50b4-4d6f-87aa-ce59b4db9901", "08c49b9d-3dcb-4a2d-9d4b-686d2f3f2e14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "979f6b9f-f0b0-49be-8683-ba7831df8e26", "29b7ff78-c5f4-4015-a0b7-ec8cf5f533c8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8b41ab70-a495-41c3-a7f3-1437c3326150", "4ee98ffa-0281-4866-a596-02579bb828dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d92019bb-20cf-4bce-9845-35528c5e464d", "7b52428e-de63-4ecc-b961-4f69dfc84774" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cc9bbc4-50b4-4d6f-87aa-ce59b4db9901");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b41ab70-a495-41c3-a7f3-1437c3326150");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "979f6b9f-f0b0-49be-8683-ba7831df8e26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d92019bb-20cf-4bce-9845-35528c5e464d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08c49b9d-3dcb-4a2d-9d4b-686d2f3f2e14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29b7ff78-c5f4-4015-a0b7-ec8cf5f533c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ee98ffa-0281-4866-a596-02579bb828dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b52428e-de63-4ecc-b961-4f69dfc84774");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ChartSets");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09b76c99-9f45-4968-a8cd-277a1c4ad2be", "77202e02-038b-4dde-af30-d1b570a4658f", "Admin", "ADMIN" },
                    { "7d1ec22d-b697-4a6f-b4bd-b26c8cb32e51", "a390e88d-a5bd-45f1-b0f0-144003575016", "Featured Artist", "FEATURED ARTIST" },
                    { "d3ef9cd0-2c42-4495-8055-7ca4b2940236", "09664e79-4098-4a5f-ba51-bda37bc6bfed", "User", "USER" },
                    { "db7c9eab-0c74-48ae-98c0-d022c385af87", "b15a29b6-ff0d-40ed-a963-4fe96d03ed07", "Mapper", "MAPPER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreationDate", "Email", "EmailConfirmed", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileBannerPath", "ProfilePicturePath", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "053e8216-21b7-4a12-8429-7f86e1bf80c6", 0, "b46d323e-7d01-466b-b7f0-6b487792f68a", new DateTime(2023, 6, 14, 15, 48, 30, 441, DateTimeKind.Local).AddTicks(340), "fa@arist.com", true, new DateTime(2023, 6, 14, 15, 48, 30, 441, DateTimeKind.Local).AddTicks(345), false, null, "FA@ARIST.COM", "NAMIRIN", "AQAAAAEAACcQAAAAEPrhrK306ePSuJn2kOj6/u1A0PaqsSK4PvYiUEcQYfHEnfJ+Ets59OybECz1zRfckQ==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "cc61c913-cde6-4ccc-ac89-8bda38c1484e", false, "namirin" },
                    { "205f8c80-a762-4384-85d9-9d82564fc7df", 0, "9a2a136c-ff1f-475a-b572-9f547e8a9687", new DateTime(2023, 6, 14, 15, 48, 30, 438, DateTimeKind.Local).AddTicks(4751), "u@user.com", true, new DateTime(2023, 6, 14, 15, 48, 30, 438, DateTimeKind.Local).AddTicks(4756), false, null, "U@USER.COM", "ONEGAI", "AQAAAAEAACcQAAAAEFWt88gMI+uPxA6lg+4BmkFctUhuotfLp0aPL2pT4ma8kaOAgehiVIHCVPMtkUQxFQ==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "2b7c6f07-381c-4b89-b38c-fa20cc78a07d", false, "onegai" },
                    { "67a443b6-e598-444d-b30c-6eb7be2219ae", 0, "d0d842d3-a27c-4c9f-98ca-26bf72a95999", new DateTime(2023, 6, 14, 15, 48, 30, 435, DateTimeKind.Local).AddTicks(8730), "a@admin.com", true, new DateTime(2023, 6, 14, 15, 48, 30, 435, DateTimeKind.Local).AddTicks(8812), false, null, "A@ADMIN.COM", "SHAD0W", "AQAAAAEAACcQAAAAEClRS66nu+GyGqdRK6QAYzXS8yAOjSAMbxMNKf7ZKvEzykiNkFhxs7P2LxfhkadOOA==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "e320189c-9abb-4f71-9773-8347924120f8", false, "shad0w" },
                    { "b968f17c-335c-424b-8123-4d15e925b7dc", 0, "e3c98e7b-fc3f-4e6f-bc7c-b05e7f4786c2", new DateTime(2023, 6, 14, 15, 48, 30, 443, DateTimeKind.Local).AddTicks(5960), "m@mapper.com", true, new DateTime(2023, 6, 14, 15, 48, 30, 443, DateTimeKind.Local).AddTicks(5965), false, null, "M@MAPPER.COM", "SOTARKS", "AQAAAAEAACcQAAAAEKUQNmxcwx5Vr2tmdSFeDLb9WNLrH00FWZF8v2iRG9g7esamAqRWvqA9KcncgfH1Yg==", null, false, "Users/ProfileBanners/default.png", "Users/ProfilePictures/default.png", "51c4f3b5-55d9-4352-bfa7-29d4af6e1fbd", false, "Sotarks" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7d1ec22d-b697-4a6f-b4bd-b26c8cb32e51", "053e8216-21b7-4a12-8429-7f86e1bf80c6" },
                    { "d3ef9cd0-2c42-4495-8055-7ca4b2940236", "205f8c80-a762-4384-85d9-9d82564fc7df" },
                    { "09b76c99-9f45-4968-a8cd-277a1c4ad2be", "67a443b6-e598-444d-b30c-6eb7be2219ae" },
                    { "db7c9eab-0c74-48ae-98c0-d022c385af87", "b968f17c-335c-424b-8123-4d15e925b7dc" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7d1ec22d-b697-4a6f-b4bd-b26c8cb32e51", "053e8216-21b7-4a12-8429-7f86e1bf80c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3ef9cd0-2c42-4495-8055-7ca4b2940236", "205f8c80-a762-4384-85d9-9d82564fc7df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09b76c99-9f45-4968-a8cd-277a1c4ad2be", "67a443b6-e598-444d-b30c-6eb7be2219ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db7c9eab-0c74-48ae-98c0-d022c385af87", "b968f17c-335c-424b-8123-4d15e925b7dc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b76c99-9f45-4968-a8cd-277a1c4ad2be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d1ec22d-b697-4a6f-b4bd-b26c8cb32e51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ef9cd0-2c42-4495-8055-7ca4b2940236");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7c9eab-0c74-48ae-98c0-d022c385af87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "053e8216-21b7-4a12-8429-7f86e1bf80c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "205f8c80-a762-4384-85d9-9d82564fc7df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67a443b6-e598-444d-b30c-6eb7be2219ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b968f17c-335c-424b-8123-4d15e925b7dc");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ChartSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
