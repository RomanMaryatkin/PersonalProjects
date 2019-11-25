﻿// <auto-generated />
using GloriousProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GloriousProject.Migrations
{
    [DbContext(typeof(EntityFrameworkDbContext))]
    [Migration("20190123143025_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GloriousProject.Models.Lesson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("auditorium");

                    b.Property<int>("auditoriumAmount");

                    b.Property<int>("auditoriumOid");

                    b.Property<string>("author");

                    b.Property<string>("beginLesson");

                    b.Property<string>("building");

                    b.Property<string>("createddate");

                    b.Property<string>("date");

                    b.Property<string>("dateOfNest");

                    b.Property<int>("dayOfWeek");

                    b.Property<string>("dayOfWeekString");

                    b.Property<string>("detailInfo");

                    b.Property<string>("discipline");

                    b.Property<int>("disciplineOid");

                    b.Property<string>("disciplineinplan");

                    b.Property<int>("disciplinetypeload");

                    b.Property<string>("endLesson");

                    b.Property<int>("group");

                    b.Property<int>("groupOid");

                    b.Property<int>("hideincapacity");

                    b.Property<bool>("isBan");

                    b.Property<string>("kindOfWork");

                    b.Property<string>("lecturer");

                    b.Property<int>("lecturerOid");

                    b.Property<int>("lessonNumberEnd");

                    b.Property<int>("lessonNumberStart");

                    b.Property<string>("modifieddate");

                    b.Property<string>("parentschedule");

                    b.Property<string>("stream");

                    b.Property<int>("streamOid");

                    b.Property<int>("subGroup");

                    b.Property<int>("subGroupOid");

                    b.HasKey("id");

                    b.ToTable("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
