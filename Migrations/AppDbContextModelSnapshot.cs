﻿// <auto-generated />
using System;
using HolidayChecklist.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HolidayChecklist.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("HolidayChecklist.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EpisodeAirDate");

                    b.Property<int>("EpisodeNumber");

                    b.Property<string>("EpisodeOverview");

                    b.Property<string>("EpisodeTitle");

                    b.Property<int>("SeasonNumber");

                    b.Property<string>("ShowBackdropPath");

                    b.Property<int>("ShowID");

                    b.Property<string>("ShowOverview");

                    b.Property<string>("ShowTitle");

                    b.Property<bool>("Watched");

                    b.HasKey("EpisodeID");

                    b.ToTable("Episode");
                });
#pragma warning restore 612, 618
        }
    }
}
