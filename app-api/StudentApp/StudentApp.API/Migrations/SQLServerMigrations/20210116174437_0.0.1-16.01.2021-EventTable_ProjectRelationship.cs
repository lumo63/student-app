﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApp.API.Migrations.SQLServerMigrations
{
    public partial class _00116012021EventTable_ProjectRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Subject_SemesterDefinitionKey",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TypeDefinitionKey",
                table: "Subject");

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SetTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsArchive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventKey);
                    table.ForeignKey(
                        name: "FK_Event_Project_ProjectKey",
                        column: x => x.ProjectKey,
                        principalTable: "Project",
                        principalColumn: "ProjectKey");
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("27fd71bf-f9e1-4293-a494-be76b477c706"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("9969b359-b888-4d07-8e0a-f79234f58adb"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("9a684681-ffac-42e6-97a5-c07fb18e2a32"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("c94de30c-a03a-4432-91a1-310ace86050a"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("5331b1c1-3bdb-4a06-8150-c3eb56a5364f"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("9f7116df-ae43-49e9-9144-99a299e38fd5"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("c7effbb1-77c8-4b99-824e-d3dcd985c8c8"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("ce1c4999-ea15-4aef-816f-df1d0ab501ee"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136), new DateTime(2021, 1, 16, 18, 44, 37, 343, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SemesterDefinitionKey",
                table: "Subject",
                column: "SemesterDefinitionKey");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TypeDefinitionKey",
                table: "Subject",
                column: "TypeDefinitionKey");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ProjectKey",
                table: "Event",
                column: "ProjectKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SemesterDefinitionKey",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TypeDefinitionKey",
                table: "Subject");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("27fd71bf-f9e1-4293-a494-be76b477c706"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("9969b359-b888-4d07-8e0a-f79234f58adb"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("9a684681-ffac-42e6-97a5-c07fb18e2a32"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "CategoryKey",
                keyValue: new Guid("c94de30c-a03a-4432-91a1-310ace86050a"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000022"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("5331b1c1-3bdb-4a06-8150-c3eb56a5364f"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("9f7116df-ae43-49e9-9144-99a299e38fd5"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Definition",
                keyColumn: "DefinitionKey",
                keyValue: new Guid("c7effbb1-77c8-4b99-824e-d3dcd985c8c8"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("bdfc4999-ea15-4aef-816f-df1d0ab501ee"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "DefinitionGroup",
                keyColumn: "DefinitionGroupKey",
                keyValue: new Guid("ce1c4999-ea15-4aef-816f-df1d0ab501ee"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "StatusKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserKey",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateTime", "ModifyTime" },
                values: new object[] { new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885), new DateTime(2021, 1, 13, 20, 13, 15, 319, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SemesterDefinitionKey",
                table: "Subject",
                column: "SemesterDefinitionKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TypeDefinitionKey",
                table: "Subject",
                column: "TypeDefinitionKey",
                unique: true);
        }
    }
}
