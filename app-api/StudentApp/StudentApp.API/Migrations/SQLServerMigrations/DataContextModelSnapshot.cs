﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApp.Tools.Configurations;

namespace StudentApp.API.Migrations.SQLServerMigrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            OrderIndex = 1,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000022")
                        },
                        new
                        {
                            CategoryKey = new Guid("c94de30c-a03a-4432-91a1-310ace86050a"),
                            CategoryName = "Kartkówka",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            OrderIndex = 2,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000022")
                        },
                        new
                        {
                            CategoryKey = new Guid("27fd71bf-f9e1-4293-a494-be76b477c706"),
                            CategoryName = "Projekt zespołowy",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            OrderIndex = 1,
                            ProjectTypeKey = new Guid("00000000-0000-0000-0000-000000000012")
                        },
                        new
                        {
                            CategoryKey = new Guid("9969b359-b888-4d07-8e0a-f79234f58adb"),
                            CategoryName = "Projekt zaliczeniowy",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
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
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "Laboratoria"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000021"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000001"),
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "Wykład"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000012"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "Projekt"
                        },
                        new
                        {
                            DefinitionKey = new Guid("00000000-0000-0000-0000-000000000022"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "Egzamin"
                        },
                        new
                        {
                            DefinitionKey = new Guid("c7effbb1-77c8-4b99-824e-d3dcd985c8c8"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = true,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "1"
                        },
                        new
                        {
                            DefinitionKey = new Guid("9f7116df-ae43-49e9-9144-99a299e38fd5"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Value = "2"
                        },
                        new
                        {
                            DefinitionKey = new Guid("5331b1c1-3bdb-4a06-8150-c3eb56a5364f"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Default = false,
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
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
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "Typ zajęć",
                            GroupName = "SUBJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "Typ projektu",
                            GroupName = "PROJECT_TYPES",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "Semestr użytkownika admin",
                            GroupName = "admin_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136)
                        },
                        new
                        {
                            DefinitionGroupKey = new Guid("ce1c4999-ea15-4aef-816f-df1d0ab501ee"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "Semestr użytkownika admin-front",
                            GroupName = "admin-front_SEMESTERS",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136)
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
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Name = "Nowy",
                            Type = 0
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Name = "Otwarty",
                            Type = 1
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000003"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Name = "W trakcie",
                            Type = 2
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000004"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Name = "Wstrzymany",
                            Type = 3
                        },
                        new
                        {
                            StatusKey = new Guid("00000000-0000-0000-0000-000000000005"),
                            Color = "ffffff",
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Description = "",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
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

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

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
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            EmailAddress = "",
                            FirstName = "admin",
                            LastName = "",
                            LoginName = "admin",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Password = "cyberbug2021",
                            SemesterDefinitionGroupKey = new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee")
                        },
                        new
                        {
                            UserKey = new Guid("00000000-0000-0000-0000-000000000002"),
                            CreateTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            EmailAddress = "",
                            FirstName = "admin-front",
                            LastName = "",
                            LoginName = "admin-front",
                            ModifyTime = new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136),
                            Password = "cyberbug2021",
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
