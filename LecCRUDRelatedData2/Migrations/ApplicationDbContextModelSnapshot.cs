﻿// <auto-generated />
using LecCRUDRelatedData2.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LecCRUDRelatedData2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Internship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("StudentENumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("StudentENumber")
                        .IsUnique();

                    b.ToTable("Internships");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Student", b =>
                {
                    b.Property<string>("ENumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("ENumber");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.StudentCourseGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("LetterGrade")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("StudentENumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentENumber");

                    b.ToTable("StudentCourseGrades");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Internship", b =>
                {
                    b.HasOne("LecCRUDRelatedData2.Models.Entities.Student", "Student")
                        .WithOne("Internship")
                        .HasForeignKey("LecCRUDRelatedData2.Models.Entities.Internship", "StudentENumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.StudentCourseGrade", b =>
                {
                    b.HasOne("LecCRUDRelatedData2.Models.Entities.Course", "Course")
                        .WithMany("StudentGrades")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LecCRUDRelatedData2.Models.Entities.Student", "Student")
                        .WithMany("CourseGrades")
                        .HasForeignKey("StudentENumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Course", b =>
                {
                    b.Navigation("StudentGrades");
                });

            modelBuilder.Entity("LecCRUDRelatedData2.Models.Entities.Student", b =>
                {
                    b.Navigation("CourseGrades");

                    b.Navigation("Internship");
                });
#pragma warning restore 612, 618
        }
    }
}
