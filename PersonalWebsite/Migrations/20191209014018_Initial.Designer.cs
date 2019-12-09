﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalWebsite.Models;

namespace PersonalWebsite.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191209014018_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalWebsite.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlayerName");

                    b.Property<int>("PlayerScore");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("PersonalWebsite.Models.Riddle", b =>
                {
                    b.Property<int>("RiddleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CorrectAnswer");

                    b.Property<string>("RiddleText");

                    b.HasKey("RiddleID");

                    b.ToTable("Riddles");
                });
#pragma warning restore 612, 618
        }
    }
}
