﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NineStarKi.Models;

namespace NineStarKi.Migrations
{
    [DbContext(typeof(PDbContext))]
    partial class PDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NineStarKi.Models.Genre", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MusicianId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MusicianId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("NineStarKi.Models.Musician", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numbers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recording")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("NineStarKi.Models.Occasion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("MusicianId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MusicianId");

                    b.ToTable("Occasions");
                });

            modelBuilder.Entity("NineStarKi.Models.Personality", b =>
                {
                    b.Property<int>("PersonalityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalityID");

                    b.ToTable("Personalities");
                });

            modelBuilder.Entity("NineStarKi.Models.Genre", b =>
                {
                    b.HasOne("NineStarKi.Models.Musician", null)
                        .WithMany("Genres")
                        .HasForeignKey("MusicianId");
                });

            modelBuilder.Entity("NineStarKi.Models.Occasion", b =>
                {
                    b.HasOne("NineStarKi.Models.Musician", null)
                        .WithMany("Occasions")
                        .HasForeignKey("MusicianId");
                });

            modelBuilder.Entity("NineStarKi.Models.Musician", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Occasions");
                });
#pragma warning restore 612, 618
        }
    }
}
