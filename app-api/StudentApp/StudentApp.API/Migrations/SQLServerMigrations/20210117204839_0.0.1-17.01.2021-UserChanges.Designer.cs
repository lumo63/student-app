﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApp.Tools.Configurations;

namespace StudentApp.API.Migrations.SQLServerMigrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210117204839_0.0.1-17.01.2021-UserChanges")]
    partial class _00117012021UserChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("StudentApp.Services.Model.Category", b =>
                {
                    b.Property<Guid>("CategoryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<Guid>("ProjectTypeKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryKey");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryKey = new Guid("9a684681-ffac-42e6-97a5-c07fb18e2a32"),
                            CategoryName = "Odpowiedź ustna",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            OrderIndex = 1,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000022")
                        },
                        new
                        {
                            CategoryKey = new Guid("c94de30c-a03a-4432-91a1-310ace86050a"),
                            CategoryName = "Kartkówka",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            OrderIndex = 2,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000022")
                        },
                        new
                        {
                            CategoryKey = new Guid("27fd71bf-f9e1-4293-a494-be76b477c706"),
                            CategoryName = "Projekt zespołowy",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            OrderIndex = 1,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000012")
                        },
                        new
                        {
                            CategoryKey = new Guid("9969b359-b888-4d07-8e0a-f79234f58adb"),
                            CategoryName = "Projekt zaliczeniowy",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            OrderIndex = 2,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000012")
                        });
                });

            modelBuilder.Entity("StudentApp.Services.Model.Definition", b =>
                {
                    b.Property<Guid>("DefinitionKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Default")
                        .HasColumnType("bit");

                    b.Property<Guid>("DefinitionGroupKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DefinitionKey");

                    b.HasIndex("DefinitionGroupKey");

                    b.ToTable("Definition");

                    b.HasData(
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000011"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "Laboratoria"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000021"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "Wykład"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000012"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "Projekt"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000022"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "Egzamin"
                        },
                        new
                        {
                            DefinitionKey = new Guid("c7effbb1-77c8-4b99-824e-d3dcd985c8c8"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = true,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "1"
                        },
                        new
                        {
                            DefinitionKey = new Guid("9f7116df-ae43-49e9-9144-99a299e38fd5"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "2"
                        },
                        new
                        {
                            DefinitionKey = new Guid("5331b1c1-3bdb-4a06-8150-c3eb56a5364f"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Default = false,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Value = "3"
                        });
                });

            modelBuilder.Entity("StudentApp.Services.Model.DefinitionGroup", b =>
                {
                    b.Property<Guid>("DefinitionGroupKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.HasKey("DefinitionGroupKey");

                    b.ToTable("DefinitionGroup");

                    b.HasData(
                        new
                        {
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "Typ zajęć",
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "Typ projektu",
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "Semestr użytkownika admin",
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("ce1c4999-ea15-4aef-816f-df1d0ab501ee"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "Semestr użytkownika admin-front",
                            GroupName = "admin-front_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588)
                        });
                });

            modelBuilder.Entity("StudentApp.Services.Model.Event", b =>
                {
                    b.Property<Guid>("EventKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsArchive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProjectKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SetTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventKey");

                    b.HasIndex("ProjectKey");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Project", b =>
                {
                    b.Property<Guid>("ProjectKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadlineTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchive")
                        .HasColumnType("bit");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NecessaryToPass")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectStatusKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubjectKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeDefinitionKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkingAreaKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProjectKey");

                    b.HasIndex("CategoryKey");

                    b.HasIndex("ProjectStatusKey");

                    b.HasIndex("SubjectKey");

                    b.HasIndex("TypeDefinitionKey");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Status", b =>
                {
                    b.Property<Guid>("StatusKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("StatusKey");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Name = "Nowy",
                            Type = 0
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Name = "Otwarty",
                            Type = 1
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000003"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Name = "W trakcie",
                            Type = 2
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000004"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Name = "Wstrzymany",
                            Type = 3
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000005"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            Name = "Zakończony",
                            Type = 4
                        });
                });

            modelBuilder.Entity("StudentApp.Services.Model.Subject", b =>
                {
                    b.Property<Guid>("SubjectKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasProjectToPass")
                        .HasColumnType("bit");

                    b.Property<bool>("IsArchive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SemesterDefinitionKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TypeDefinitionKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectKey");

                    b.HasIndex("SemesterDefinitionKey");

                    b.HasIndex("TypeDefinitionKey");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("StudentApp.Services.Model.User", b =>
                {
                    b.Property<Guid>("UserKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("SemesterDefinitionGroupKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserKey");

                    b.HasIndex("SemesterDefinitionGroupKey")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            EmailAddress = "",
                            FirstName = "admin",
                            LastName = "",
                            LoginName = "admin",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            PasswordHash = new byte[] { 175, 72, 199, 212, 95, 190, 179, 144, 148, 91, 27, 117, 229, 181, 239, 182, 253, 225, 247, 44, 15, 199, 139, 177, 34, 52, 213, 40, 41, 230, 34, 193, 252, 240, 160, 40, 63, 35, 165, 203, 60, 49, 90, 13, 203, 77, 218, 167, 196, 66, 60, 132, 48, 179, 251, 148, 184, 28, 131, 188, 108, 147, 204, 214 },
                            PasswordSalt = new byte[] { 153, 70, 102, 152, 173, 143, 158, 191, 178, 40, 16, 252, 11, 181, 240, 106, 203, 100, 153, 217, 215, 186, 200, 67, 92, 188, 251, 20, 149, 52, 67, 0, 107, 218, 87, 156, 246, 172, 88, 154, 234, 204, 146, 208, 226, 228, 66, 255, 183, 1, 167, 170, 46, 210, 157, 31, 123, 57, 150, 56, 18, 243, 156, 61, 84, 38, 6, 131, 155, 151, 36, 18, 200, 55, 167, 9, 132, 92, 52, 120, 31, 125, 106, 246, 195, 49, 148, 122, 4, 33, 197, 199, 198, 114, 144, 97, 141, 109, 176, 21, 202, 34, 171, 209, 229, 104, 192, 188, 209, 201, 105, 128, 129, 91, 161, 229, 46, 18, 165, 177, 105, 129, 193, 190, 48, 214, 72, 126 },
                            SemesterDefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee")
                        },
                        new
                        {
                            UserKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreateTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            EmailAddress = "",
                            FirstName = "admin-front",
                            LastName = "",
                            LoginName = "admin-front",
                            ModifyTime = new DateTime(2021, 1, 17, 21, 48, 38, 183, DateTimeKind.Local).AddTicks(7588),
                            PasswordHash = new byte[] { 175, 72, 199, 212, 95, 190, 179, 144, 148, 91, 27, 117, 229, 181, 239, 182, 253, 225, 247, 44, 15, 199, 139, 177, 34, 52, 213, 40, 41, 230, 34, 193, 252, 240, 160, 40, 63, 35, 165, 203, 60, 49, 90, 13, 203, 77, 218, 167, 196, 66, 60, 132, 48, 179, 251, 148, 184, 28, 131, 188, 108, 147, 204, 214 },
                            PasswordSalt = new byte[] { 153, 70, 102, 152, 173, 143, 158, 191, 178, 40, 16, 252, 11, 181, 240, 106, 203, 100, 153, 217, 215, 186, 200, 67, 92, 188, 251, 20, 149, 52, 67, 0, 107, 218, 87, 156, 246, 172, 88, 154, 234, 204, 146, 208, 226, 228, 66, 255, 183, 1, 167, 170, 46, 210, 157, 31, 123, 57, 150, 56, 18, 243, 156, 61, 84, 38, 6, 131, 155, 151, 36, 18, 200, 55, 167, 9, 132, 92, 52, 120, 31, 125, 106, 246, 195, 49, 148, 122, 4, 33, 197, 199, 198, 114, 144, 97, 141, 109, 176, 21, 202, 34, 171, 209, 229, 104, 192, 188, 209, 201, 105, 128, 129, 91, 161, 229, 46, 18, 165, 177, 105, 129, 193, 190, 48, 214, 72, 126 },
                            SemesterDefinitionGroupKey = new Guid("ce1c4999-ea15-4aef-816f-df1d0ab501ee")
                        });
                });

            modelBuilder.Entity("StudentApp.Services.Model.Definition", b =>
                {
                    b.HasOne("StudentApp.Services.Model.DefinitionGroup", "DefinitionGroup")
                        .WithMany("Definitions")
                        .HasForeignKey("DefinitionGroupKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("DefinitionGroup");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Event", b =>
                {
                    b.HasOne("StudentApp.Services.Model.Project", "Project")
                        .WithMany("ProjectEvents")
                        .HasForeignKey("ProjectKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Project", b =>
                {
                    b.HasOne("StudentApp.Services.Model.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("StudentApp.Services.Model.Status", "Status")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectStatusKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("StudentApp.Services.Model.Subject", "Subject")
                        .WithMany("Projects")
                        .HasForeignKey("SubjectKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("StudentApp.Services.Model.Definition", "DefinitionType")
                        .WithMany("ProjectStatusDefinitions")
                        .HasForeignKey("TypeDefinitionKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("DefinitionType");

                    b.Navigation("Status");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Subject", b =>
                {
                    b.HasOne("StudentApp.Services.Model.Definition", "SemesterDefinition")
                        .WithMany("SubjectSemesterDefinitions")
                        .HasForeignKey("SemesterDefinitionKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("StudentApp.Services.Model.Definition", "StatusDefinition")
                        .WithMany("SubjectStatusDefinitions")
                        .HasForeignKey("TypeDefinitionKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("SemesterDefinition");

                    b.Navigation("StatusDefinition");
                });

            modelBuilder.Entity("StudentApp.Services.Model.User", b =>
                {
                    b.HasOne("StudentApp.Services.Model.DefinitionGroup", "SemesterDefinitionGroup")
                        .WithOne("UserSemesterDefinitionGroup")
                        .HasForeignKey("StudentApp.Services.Model.User", "SemesterDefinitionGroupKey")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.Navigation("SemesterDefinitionGroup");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Category", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Definition", b =>
                {
                    b.Navigation("ProjectStatusDefinitions");

                    b.Navigation("SubjectSemesterDefinitions");

                    b.Navigation("SubjectStatusDefinitions");
                });

            modelBuilder.Entity("StudentApp.Services.Model.DefinitionGroup", b =>
                {
                    b.Navigation("Definitions");

                    b.Navigation("UserSemesterDefinitionGroup");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Project", b =>
                {
                    b.Navigation("ProjectEvents");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Status", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("StudentApp.Services.Model.Subject", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
