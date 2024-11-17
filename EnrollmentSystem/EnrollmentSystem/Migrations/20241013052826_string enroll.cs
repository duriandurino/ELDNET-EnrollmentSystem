using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class stringenroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Courses_course_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Rooms_room_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Semesters_Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Students_Studentstud_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_course_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_room_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Studentstud_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Subjectsubj_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Studentstud_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Subjectsubj_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "room_id",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Semestersem_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Studentstud_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Subjectsubj_id",
                table: "Enrolls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "Enrolls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "room_id",
                table: "Enrolls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_course_id",
                table: "Enrolls",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_room_id",
                table: "Enrolls",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Semestersem_id",
                table: "Enrolls",
                column: "Semestersem_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Studentstud_id",
                table: "Enrolls",
                column: "Studentstud_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Subjectsubj_id",
                table: "Enrolls",
                column: "Subjectsubj_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Courses_course_id",
                table: "Enrolls",
                column: "course_id",
                principalTable: "Courses",
                principalColumn: "course_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Rooms_room_id",
                table: "Enrolls",
                column: "room_id",
                principalTable: "Rooms",
                principalColumn: "room_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Semesters_Semestersem_id",
                table: "Enrolls",
                column: "Semestersem_id",
                principalTable: "Semesters",
                principalColumn: "sem_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Students_Studentstud_id",
                table: "Enrolls",
                column: "Studentstud_id",
                principalTable: "Students",
                principalColumn: "stud_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls",
                column: "Subjectsubj_id",
                principalTable: "Subjects",
                principalColumn: "subj_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
