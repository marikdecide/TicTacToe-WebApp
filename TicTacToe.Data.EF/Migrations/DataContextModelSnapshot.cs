﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicTacToe.Data.EF;

namespace TicTacToe.Data.EF.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicTacToe.Models.Entity.Cell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cell");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1.1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "1.2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "1.3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "2.1"
                        },
                        new
                        {
                            Id = 5,
                            Name = "2.2"
                        },
                        new
                        {
                            Id = 6,
                            Name = "2.3"
                        },
                        new
                        {
                            Id = 7,
                            Name = "3.1"
                        },
                        new
                        {
                            Id = 8,
                            Name = "3.2"
                        },
                        new
                        {
                            Id = 9,
                            Name = "3.3"
                        });
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LoserPlayerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<int?>("WinnerPlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LoserPlayerId");

                    b.HasIndex("WinnerPlayerId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.GameSide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameSide");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Crosses"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zeros"
                        });
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Move", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CellId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("MoveNumber")
                        .HasColumnType("int");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CellId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Move");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameSideId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameSideId");

                    b.HasIndex("UserId");

                    b.ToTable("Player");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameSideId = 1,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 2,
                            GameSideId = 2,
                            Name = "PC"
                        });
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EntryDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Game", b =>
                {
                    b.HasOne("TicTacToe.Models.Entity.Player", "LoserPlayer")
                        .WithMany("LoserGames")
                        .HasForeignKey("LoserPlayerId");

                    b.HasOne("TicTacToe.Models.Entity.Player", "WinnerPlayer")
                        .WithMany("WinnerGames")
                        .HasForeignKey("WinnerPlayerId");

                    b.Navigation("LoserPlayer");

                    b.Navigation("WinnerPlayer");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Move", b =>
                {
                    b.HasOne("TicTacToe.Models.Entity.Cell", "Cell")
                        .WithMany("Moves")
                        .HasForeignKey("CellId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicTacToe.Models.Entity.Game", "Game")
                        .WithMany("Moves")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicTacToe.Models.Entity.Player", "Player")
                        .WithMany("Moves")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cell");

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Player", b =>
                {
                    b.HasOne("TicTacToe.Models.Entity.GameSide", "GameSide")
                        .WithMany("Players")
                        .HasForeignKey("GameSideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicTacToe.Models.Entity.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId");

                    b.Navigation("GameSide");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Cell", b =>
                {
                    b.Navigation("Moves");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Game", b =>
                {
                    b.Navigation("Moves");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.GameSide", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.Player", b =>
                {
                    b.Navigation("LoserGames");

                    b.Navigation("Moves");

                    b.Navigation("WinnerGames");
                });

            modelBuilder.Entity("TicTacToe.Models.Entity.User", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
