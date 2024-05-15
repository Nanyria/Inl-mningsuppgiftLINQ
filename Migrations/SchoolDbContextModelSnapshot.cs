﻿// <auto-generated />
using System;
using InlämningsuppgiftLINQ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int?>("courseID")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("TeacherID");

                    b.HasIndex("courseID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("SubjectsName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubjectID");

                    b.HasIndex("CourseID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"), 1L, 1);

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.CourseStudentsCollection", b =>
                {
                    b.Property<int>("CStuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CStuID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int?>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("CStuID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.HasIndex("SubjectID");

                    b.ToTable("CourseStudentsCollections");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.CourseSubjectsCollection", b =>
                {
                    b.Property<int>("CSubID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CSubID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("CSubID");

                    b.HasIndex("CourseID");

                    b.HasIndex("SubjectID");

                    b.ToTable("CourseSubjectsCollections");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.PrimaryTeacherStudent", b =>
                {
                    b.Property<int>("PTSID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PTSID"), 1L, 1);

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("PTSID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TeacherID");

                    b.ToTable("primaryTeacherStudents");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.StudentTeachersCollection", b =>
                {
                    b.Property<int>("StudentTeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentTeacherID"), 1L, 1);

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("StudentTeacherID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TeacherID");

                    b.ToTable("StudentTeachersCollections");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.SubjectTeachersCollection", b =>
                {
                    b.Property<int>("STID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("STID"), 1L, 1);

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("STID");

                    b.HasIndex("SubjectID");

                    b.HasIndex("TeacherID");

                    b.ToTable("SubjectTeachersCollection");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Student", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("TeacherID");

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("courseID");

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Subject", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Course", null)
                        .WithMany("Subjects")
                        .HasForeignKey("CourseID");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.CourseStudentsCollection", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Subject", null)
                        .WithMany("CourseStudents")
                        .HasForeignKey("SubjectID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.CourseSubjectsCollection", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.PrimaryTeacherStudent", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.StudentTeachersCollection", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Student", "Student")
                        .WithMany("StudentTeachers")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", "Teacher")
                        .WithMany("StudentTeachers")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.CollectionTables.SubjectTeachersCollection", b =>
                {
                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Subject", "Subject")
                        .WithMany("SubjectTeachers")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", "Teacher")
                        .WithMany("TeacherSubjects")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Course", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Student", b =>
                {
                    b.Navigation("StudentTeachers");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Subject", b =>
                {
                    b.Navigation("CourseStudents");

                    b.Navigation("SubjectTeachers");
                });

            modelBuilder.Entity("InlämningsuppgiftLINQ.Models.BaseModels.Teacher", b =>
                {
                    b.Navigation("StudentTeachers");

                    b.Navigation("Students");

                    b.Navigation("TeacherSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
