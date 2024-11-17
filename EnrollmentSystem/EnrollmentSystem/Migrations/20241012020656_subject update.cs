using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class subjectupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "subj_time",
                table: "Subjects",
                newName: "subj_starttime");

            migrationBuilder.AddColumn<DateTime>(
                name: "subj_endtime",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "subj_endtime",
                table: "Subjects");

            migrationBuilder.RenameColumn(
                name: "subj_starttime",
                table: "Subjects",
                newName: "subj_time");
        }
    }
}
