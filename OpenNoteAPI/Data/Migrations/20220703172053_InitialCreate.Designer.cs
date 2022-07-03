﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenNoteAPI.Data;

#nullable disable

namespace OpenNoteAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220703172053_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OpenNoteAPI.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet",
                            CreatedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4835),
                            ModifiedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4846),
                            Title = "Sample Note 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Amet lorem ipsum dolor sit",
                            CreatedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4849),
                            ModifiedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4849),
                            Title = "Sample Note 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Sit amet lorem ipsum dolor",
                            CreatedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4851),
                            ModifiedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4851),
                            Title = "Sample Note 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "dolor sit amet lorem ipsum",
                            CreatedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4852),
                            ModifiedTime = new DateTime(2022, 7, 3, 20, 20, 53, 766, DateTimeKind.Local).AddTicks(4852),
                            Title = "Sample Note 4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}