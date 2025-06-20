﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiklaaGame.Data;

#nullable disable

namespace tiklaa_blazor_game.Migrations
{
    [DbContext(typeof(TiklaaDbContext))]
    [Migration("20250618210145_werf")]
    partial class werf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tiklaa_blazor_game.gamee.Db_game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GameID"));

                    b.Property<string>("Animal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClickCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Skor")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("GameID");

                    b.HasIndex("UserID");

                    b.ToTable("Db_Games");
                });

            modelBuilder.Entity("tiklaa_blazor_game.gamee.Db_leader", b =>
                {
                    b.Property<int>("leaderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("leaderID"));

                    b.Property<int>("Clickcount")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("leaderID");

                    b.ToTable("Db_leaders");
                });

            modelBuilder.Entity("tiklaa_blazor_game.gamee.Db_user", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Db_Users");
                });

            modelBuilder.Entity("tiklaa_blazor_game.gamee.Db_game", b =>
                {
                    b.HasOne("tiklaa_blazor_game.gamee.Db_user", "user")
                        .WithMany("GamePlay")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("tiklaa_blazor_game.gamee.Db_user", b =>
                {
                    b.Navigation("GamePlay");
                });
#pragma warning restore 612, 618
        }
    }
}
