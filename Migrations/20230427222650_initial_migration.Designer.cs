﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RegistroNotasApi.Models;

#nullable disable

namespace RegistroNotasApi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230427222650_initial_migration")]
    partial class initial_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RegistroNotasApi.Models.Alternatives", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("alternative1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alternative2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alternative3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alternative4")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alternative5")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("questionId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("questionId");

                    b.ToTable("alternatives");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Answer", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("questionId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("answers");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Chapter", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("courseId")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("chapters");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Course", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.CourseRegistration", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("courseId")
                        .HasColumnType("bigint");

                    b.Property<long>("registrationId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("courseRegistrations");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Exam", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("chapterId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("score")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("exams");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Facultad", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("facultads");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.PS", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("facultadId")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("ps");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Question", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("examId")
                        .HasColumnType("bigint");

                    b.Property<string>("question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("questions");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Registration", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("courseId")
                        .HasColumnType("bigint");

                    b.Property<long>("psId")
                        .HasColumnType("bigint");

                    b.Property<long>("semesterId")
                        .HasColumnType("bigint");

                    b.Property<long>("studentId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("registrations");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Semester", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<DateTime>("endDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("initDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("semesters");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Student", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("students");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Teacher", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<int>("age")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("teachers");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.TeacherCourse", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("id"));

                    b.Property<long>("courseId")
                        .HasColumnType("bigint");

                    b.Property<long>("teacherId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("teacherCourses");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Alternatives", b =>
                {
                    b.HasOne("RegistroNotasApi.Models.Question", "question")
                        .WithMany("alternatives")
                        .HasForeignKey("questionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("question");
                });

            modelBuilder.Entity("RegistroNotasApi.Models.Question", b =>
                {
                    b.Navigation("alternatives");
                });
#pragma warning restore 612, 618
        }
    }
}
