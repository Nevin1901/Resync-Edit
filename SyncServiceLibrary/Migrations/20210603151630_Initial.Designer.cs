﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyncServiceLibrary;

namespace SyncServiceLibrary.Migrations
{
    [DbContext(typeof(ClipContext))]
    [Migration("20210603151630_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("SyncServiceLibrary.VideoFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<long>("FileSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Game")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("OnlineLocation")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sync")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ThumbnailLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThumbnailUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VideoFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
