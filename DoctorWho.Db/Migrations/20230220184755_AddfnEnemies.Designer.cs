﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20230220184755_AddfnEnemies")]
    partial class AddfnEnemies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Edwidge Danticat"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Ernest Hemingway"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Saul Bellow"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Sidney Sheldon"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Franz Kafka"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("Companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Ezra Pound",
                            WhoPlayed = "Agatha Christie"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Tennessee Williams",
                            WhoPlayed = "Danielle Steel"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Willa Cather",
                            WhoPlayed = "Lord Byron"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Langston Hughes",
                            WhoPlayed = "Somerset Maugham"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Joan Didion",
                            WhoPlayed = "Djuna Barnes"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime?>("BirthDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Null");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Null");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Null");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            DoctorName = "Smith",
                            DoctorNumber = 1
                        },
                        new
                        {
                            DoctorId = 2,
                            DoctorName = "Taylor",
                            DoctorNumber = 2
                        },
                        new
                        {
                            DoctorId = 3,
                            DoctorName = "Brown",
                            DoctorNumber = 3
                        },
                        new
                        {
                            DoctorId = 4,
                            DoctorName = "Williams",
                            DoctorNumber = 4
                        },
                        new
                        {
                            DoctorId = 5,
                            DoctorName = "Barker",
                            DoctorNumber = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("Null");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("Enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "the killer",
                            EnemyName = "Kingsley Amis"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "the suspect",
                            EnemyName = "Fannie Flagg"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "turns into a monster",
                            EnemyName = "Iceberg Slim"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "the thief",
                            EnemyName = "Camille Paglia"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "The bully",
                            EnemyName = "Maria Orczy"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Null");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(600)")
                        .HasDefaultValueSql("Null");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2000, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "special",
                            SeriesNumber = 1,
                            Title = "Wednesdays Child Is Full of Woe"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2002, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Filler",
                            SeriesNumber = 1,
                            Title = "Woe Is the Loneliest Number"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 2,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2007, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Classic",
                            SeriesNumber = 2,
                            Title = "Friend or Woe"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 2,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2010, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Filler",
                            SeriesNumber = 2,
                            Title = "Quid Pro Woe"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 3,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(2020, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Classic",
                            SeriesNumber = 3,
                            Title = "A Murder of Woes"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 5,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 4,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 1,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 6,
                            CompanionId = 3,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 7,
                            CompanionId = 2,
                            EpisodeId = 5
                        },
                        new
                        {
                            EpisodeCompanionId = 8,
                            CompanionId = 3,
                            EpisodeId = 3
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("EpisodeEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 3,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 4,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 3,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 6,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 7,
                            EnemyId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 8,
                            EnemyId = 2,
                            EpisodeId = 4
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", null)
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", null)
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodeEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("EpisodeCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("EpisodeEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("EpisodeCompanions");

                    b.Navigation("EpisodeEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
