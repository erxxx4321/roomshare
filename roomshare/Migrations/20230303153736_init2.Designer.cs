﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using roomshare.Data;

#nullable disable

namespace roomshare.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230303153736_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("roomshare.Models.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Building")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DepMon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Empty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Floor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Size")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Houses");
                });
#pragma warning restore 612, 618
        }
    }
}