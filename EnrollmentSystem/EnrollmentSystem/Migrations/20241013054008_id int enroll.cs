using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class idintenroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Course",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Semester",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Student",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Enrolls");

            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "room_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sem_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stud_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "subj_id",
                table: "Enrolls",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "room_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "sem_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "stud_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "subj_id",
                table: "Enrolls");

            migrationBuilder.AddColumn<string>(
                name: "Course",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Semester",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Student",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
