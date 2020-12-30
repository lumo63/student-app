﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApp.Tools.Configurations;

namespace StudentApp.Tools.Migrations.SqliteMigrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201223161533_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("StudentApp.Services.Model.Subject", b =>
                {
                    b.Property<Guid>("SubjectKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CurrentSubjectStateKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasProjectToPass")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsArchive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Semester")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubjectKey");

                    b.ToTable("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}