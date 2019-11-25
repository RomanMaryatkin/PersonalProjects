﻿// <auto-generated />
using GloriousProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GloriousProject.Migrations
{
    [DbContext(typeof(EntityFrameworkDbContext))]
    partial class EntityFrameworkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GloriousProject.Models.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Auditorium");

                    b.Property<string>("BeginLesson");

                    b.Property<string>("Building");

                    b.Property<string>("Date");

                    b.Property<string>("EndLesson");

                    b.Property<string>("Lecturer");

                    b.Property<string>("Name");

                    b.Property<string>("Status");

                    b.Property<string>("Stream");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Lessons");
                });
#pragma warning restore 612, 618
        }
    }
}
