﻿// <auto-generated />
using System;
using Chartify.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Chartify.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Chartify.Models.Chart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChartSetId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DifficultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DifficultyRating")
                        .HasColumnType("float");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChartSetId");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("Chartify.Models.ChartSet", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayCount")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("ChartSets");
                });

            modelBuilder.Entity("Chartify.Models.ChartsOfSets", b =>
                {
                    b.Property<string>("ChartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChartSetId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("ChartId");

                    b.HasIndex("ChartSetId");

                    b.ToTable("ChartsOfSets");
                });

            modelBuilder.Entity("Chartify.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "e148eee7-c102-43ad-b30d-df6bbc7b7052",
                            ConcurrencyStamp = "bb6fe8f8-b302-431f-9d6e-370d9ae347f7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "26c07908-50cd-4793-a6d0-18c8a2a6a2c2",
                            ConcurrencyStamp = "1cbb1dd3-c7c3-4ced-ad15-ca16820e45ab",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be",
                            ConcurrencyStamp = "74f23d4b-7d22-4f46-a45d-79ee636e2b51",
                            Name = "Featured Artist",
                            NormalizedName = "FEATURED ARTIST"
                        },
                        new
                        {
                            Id = "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9",
                            ConcurrencyStamp = "fc6519f9-3e05-415b-ae93-beca32708783",
                            Name = "Mapper",
                            NormalizedName = "MAPPER"
                        });
                });

            modelBuilder.Entity("Chartify.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileBannerPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6f03229f-09ac-4d92-9b08-5fe517eb08b6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "de41b399-ee1f-490d-9b65-d073a5b40e22",
                            CreationDate = new DateTime(2023, 6, 11, 19, 9, 39, 903, DateTimeKind.Local).AddTicks(446),
                            Email = "a@admin.com",
                            EmailConfirmed = true,
                            LastLoginDate = new DateTime(2023, 6, 11, 19, 9, 39, 903, DateTimeKind.Local).AddTicks(486),
                            LockoutEnabled = false,
                            NormalizedEmail = "A@ADMIN.COM",
                            NormalizedUserName = "SHAD0W",
                            PasswordHash = "AQAAAAEAACcQAAAAEG9hHAX2k2JDTalu5pBuXVQ2Ys6UI4nvQ4LSt+ZfJfJzGVKqkF9N2Nx1+wuFkK3v7Q==",
                            PhoneNumberConfirmed = false,
                            ProfileBannerPath = "Users/ProfileBanners/default.png",
                            ProfilePicturePath = "Users/ProfilePictures/default.png",
                            SecurityStamp = "d6a58a2f-d5db-4e4f-9b9e-a8f1af6b92bf",
                            TwoFactorEnabled = false,
                            UserName = "shad0w"
                        },
                        new
                        {
                            Id = "8b08ade8-07f0-462b-9362-eaf2606dd1a7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "52e4e53b-bb6c-4215-a0fa-c88a67d4c5f6",
                            CreationDate = new DateTime(2023, 6, 11, 19, 9, 39, 904, DateTimeKind.Local).AddTicks(2774),
                            Email = "u@user.com",
                            EmailConfirmed = true,
                            LastLoginDate = new DateTime(2023, 6, 11, 19, 9, 39, 904, DateTimeKind.Local).AddTicks(2787),
                            LockoutEnabled = false,
                            NormalizedEmail = "U@USER.COM",
                            NormalizedUserName = "ONEGAI",
                            PasswordHash = "AQAAAAEAACcQAAAAEG9N8EK+G03HXVltf8JxcFwr8YSOXHtxUazWw6QZHa7P+ur9F8azkX1iqeDPJwTY3Q==",
                            PhoneNumberConfirmed = false,
                            ProfileBannerPath = "Users/ProfileBanners/default.png",
                            ProfilePicturePath = "Users/ProfilePictures/default.png",
                            SecurityStamp = "70e12d93-ded9-4ecd-9cc8-f5fd9e9c92aa",
                            TwoFactorEnabled = false,
                            UserName = "onegai"
                        },
                        new
                        {
                            Id = "c717dfd9-74e3-4f70-9ec7-dfca8e5be297",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89a78146-2f79-416d-aad3-bc08a61c6543",
                            CreationDate = new DateTime(2023, 6, 11, 19, 9, 39, 905, DateTimeKind.Local).AddTicks(5946),
                            Email = "fa@arist.com",
                            EmailConfirmed = true,
                            LastLoginDate = new DateTime(2023, 6, 11, 19, 9, 39, 905, DateTimeKind.Local).AddTicks(5999),
                            LockoutEnabled = false,
                            NormalizedEmail = "FA@ARIST.COM",
                            NormalizedUserName = "NAMIRIN",
                            PasswordHash = "AQAAAAEAACcQAAAAELJGKiBT3YQoXZHLZKUeiuEObR9GjCT6sjTCO57Q62U9h1oqmALzg+Nk+nAiYwN2Sg==",
                            PhoneNumberConfirmed = false,
                            ProfileBannerPath = "Users/ProfileBanners/default.png",
                            ProfilePicturePath = "Users/ProfilePictures/default.png",
                            SecurityStamp = "bf523c49-da87-478c-8c51-e321c95535bc",
                            TwoFactorEnabled = false,
                            UserName = "namirin"
                        },
                        new
                        {
                            Id = "774604b1-c0a9-4198-89d1-48979fe430cc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d0131c0d-ac9c-4605-95e6-a55656a66f0c",
                            CreationDate = new DateTime(2023, 6, 11, 19, 9, 39, 907, DateTimeKind.Local).AddTicks(239),
                            Email = "m@mapper.com",
                            EmailConfirmed = true,
                            LastLoginDate = new DateTime(2023, 6, 11, 19, 9, 39, 907, DateTimeKind.Local).AddTicks(273),
                            LockoutEnabled = false,
                            NormalizedEmail = "M@MAPPER.COM",
                            NormalizedUserName = "SOTARKS",
                            PasswordHash = "AQAAAAEAACcQAAAAENDi8in0i5kxroT3/sTL1/v/AnwLGD3tkcnFiorbd4eNZwjf2ytHkfyZ3yvS70jiDg==",
                            PhoneNumberConfirmed = false,
                            ProfileBannerPath = "Users/ProfileBanners/default.png",
                            ProfilePicturePath = "Users/ProfilePictures/default.png",
                            SecurityStamp = "53521370-35f7-4357-9516-8322a1e2e39a",
                            TwoFactorEnabled = false,
                            UserName = "Sotarks"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6f03229f-09ac-4d92-9b08-5fe517eb08b6",
                            RoleId = "e148eee7-c102-43ad-b30d-df6bbc7b7052"
                        },
                        new
                        {
                            UserId = "8b08ade8-07f0-462b-9362-eaf2606dd1a7",
                            RoleId = "26c07908-50cd-4793-a6d0-18c8a2a6a2c2"
                        },
                        new
                        {
                            UserId = "c717dfd9-74e3-4f70-9ec7-dfca8e5be297",
                            RoleId = "b94c8c7c-73d9-4efb-b5c5-1d2a8951d2be"
                        },
                        new
                        {
                            UserId = "774604b1-c0a9-4198-89d1-48979fe430cc",
                            RoleId = "a7e98e28-aeec-46df-b4b1-ddb8402dd5d9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<string>("SubscribedToId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SubscribersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SubscribedToId", "SubscribersId");

                    b.HasIndex("SubscribersId");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("Chartify.Models.Chart", b =>
                {
                    b.HasOne("Chartify.Models.ChartSet", "ChartSet")
                        .WithMany("Charts")
                        .HasForeignKey("ChartSetId");

                    b.Navigation("ChartSet");
                });

            modelBuilder.Entity("Chartify.Models.ChartSet", b =>
                {
                    b.HasOne("Chartify.Models.User", "Creator")
                        .WithMany("ChartSets")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Chartify.Models.ChartsOfSets", b =>
                {
                    b.HasOne("Chartify.Models.Chart", "Chart")
                        .WithMany()
                        .HasForeignKey("ChartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chartify.Models.ChartSet", "ChartSet")
                        .WithMany()
                        .HasForeignKey("ChartSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chart");

                    b.Navigation("ChartSet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Chartify.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Chartify.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("SubscribedToId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Chartify.Models.User", null)
                        .WithMany()
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Chartify.Models.ChartSet", b =>
                {
                    b.Navigation("Charts");
                });

            modelBuilder.Entity("Chartify.Models.User", b =>
                {
                    b.Navigation("ChartSets");
                });
#pragma warning restore 612, 618
        }
    }
}
