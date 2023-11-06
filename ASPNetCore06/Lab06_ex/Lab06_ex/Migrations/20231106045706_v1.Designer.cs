﻿// <auto-generated />
using System;
using Lab06_ex.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab06_ex.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231106045706_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab06_ex.Models.Marks", b =>
                {
                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("Lab06_ex.Models.StdClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StdClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StdClassId");

                    b.ToTable("StdClass");
                });

            modelBuilder.Entity("Lab06_ex.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int?>("StdClassId")
                        .HasColumnType("int");

                    b.Property<string>("StudentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StudentAvatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StudentBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StudentPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("StdClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Lab06_ex.Models.Subjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("SubjectsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectsId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Lab06_ex.Models.Marks", b =>
                {
                    b.HasOne("Lab06_ex.Models.Student", "Students")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab06_ex.Models.Subjects", "Subjects")
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");

                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("Lab06_ex.Models.StdClass", b =>
                {
                    b.HasOne("Lab06_ex.Models.StdClass", null)
                        .WithMany("StdClasses")
                        .HasForeignKey("StdClassId");
                });

            modelBuilder.Entity("Lab06_ex.Models.Student", b =>
                {
                    b.HasOne("Lab06_ex.Models.StdClass", "StdClass")
                        .WithMany()
                        .HasForeignKey("StdClassId");

                    b.HasOne("Lab06_ex.Models.Student", null)
                        .WithMany("Students")
                        .HasForeignKey("StudentId");

                    b.Navigation("StdClass");
                });

            modelBuilder.Entity("Lab06_ex.Models.Subjects", b =>
                {
                    b.HasOne("Lab06_ex.Models.Subjects", null)
                        .WithMany("Subject")
                        .HasForeignKey("SubjectsId");
                });

            modelBuilder.Entity("Lab06_ex.Models.StdClass", b =>
                {
                    b.Navigation("StdClasses");
                });

            modelBuilder.Entity("Lab06_ex.Models.Student", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("Lab06_ex.Models.Subjects", b =>
                {
                    b.Navigation("Subject");
                });
#pragma warning restore 612, 618
        }
    }
}