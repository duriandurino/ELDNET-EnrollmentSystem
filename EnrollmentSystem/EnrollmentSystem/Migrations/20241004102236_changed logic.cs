using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class changedlogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "prof_speciality",
                table: "Professors",
                newName: "SpecSubject");

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Professors",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Subjectsubj_id",
                table: "Enrolls",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Professorprof_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Semestersem_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

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
                name: "IX_Students_user_id",
                table: "Students",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_user_id",
                table: "Professors",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_course_id",
                table: "Enrolls",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Professorprof_id",
                table: "Enrolls",
                column: "Professorprof_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_room_id",
                table: "Enrolls",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Semestersem_id",
                table: "Enrolls",
                column: "Semestersem_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Courses_course_id",
                table: "Enrolls",
                column: "course_id",
                principalTable: "Courses",
                principalColumn: "course_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Professors_Professorprof_id",
                table: "Enrolls",
                column: "Professorprof_id",
                principalTable: "Professors",
                principalColumn: "prof_id");

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
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls",
                column: "Subjectsubj_id",
                principalTable: "Subjects",
                principalColumn: "subj_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Users_user_id",
                table: "Professors",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_user_id",
                table: "Students",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Courses_course_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Professors_Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Rooms_room_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Semesters_Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Users_user_id",
                table: "Professors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_user_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_user_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Professors_user_id",
                table: "Professors");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_course_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_room_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Professors");

            migrationBuilder.DropColumn(
                name: "Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Semestersem_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "room_id",
                table: "Enrolls");

            migrationBuilder.RenameColumn(
                name: "SpecSubject",
                table: "Professors",
                newName: "prof_speciality");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectsubj_id",
                table: "Enrolls",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Subjects_Subjectsubj_id",
                table: "Enrolls",
                column: "Subjectsubj_id",
                principalTable: "Subjects",
                principalColumn: "subj_id");
        }
    }
}
