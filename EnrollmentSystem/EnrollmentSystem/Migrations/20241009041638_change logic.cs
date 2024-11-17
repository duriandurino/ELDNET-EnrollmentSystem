using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class changelogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Professors_Chair_Professorprof_id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrolls_Professors_Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Users_user_id",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_course_id",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Professors_Professorprof_id",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Rooms_room_id",
                table: "Subjects");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_course_id",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_Professorprof_id",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_room_id",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_user_id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Enrolls_Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Chair_Professorprof_id",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Professorprof_id",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "room_id",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "subj_section",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Professorprof_id",
                table: "Enrolls");

            migrationBuilder.DropColumn(
                name: "Chair_Professorprof_id",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "user_email",
                table: "Users",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Users",
                newName: "can_view");

            migrationBuilder.AddColumn<int>(
                name: "can_add",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "can_delete",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "can_edit",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "stud_mname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "stud_section",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "encodedby",
                table: "Enrolls",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "can_add",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "can_delete",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "can_edit",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "stud_section",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "encodedby",
                table: "Enrolls");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Users",
                newName: "user_email");

            migrationBuilder.RenameColumn(
                name: "can_view",
                table: "Users",
                newName: "role");

            migrationBuilder.AddColumn<int>(
                name: "Professorprof_id",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "room_id",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "subj_section",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "stud_mname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user_id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Professorprof_id",
                table: "Enrolls",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chair_Professorprof_id",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    prof_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    SpecSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_mname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.prof_id);
                    table.ForeignKey(
                        name: "FK_Professors_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_course_id",
                table: "Subjects",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Professorprof_id",
                table: "Subjects",
                column: "Professorprof_id");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_room_id",
                table: "Subjects",
                column: "room_id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_user_id",
                table: "Students",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Professorprof_id",
                table: "Enrolls",
                column: "Professorprof_id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Chair_Professorprof_id",
                table: "Departments",
                column: "Chair_Professorprof_id");

            migrationBuilder.CreateIndex(
                name: "IX_Professors_user_id",
                table: "Professors",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Professors_Chair_Professorprof_id",
                table: "Departments",
                column: "Chair_Professorprof_id",
                principalTable: "Professors",
                principalColumn: "prof_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolls_Professors_Professorprof_id",
                table: "Enrolls",
                column: "Professorprof_id",
                principalTable: "Professors",
                principalColumn: "prof_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Users_user_id",
                table: "Students",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_course_id",
                table: "Subjects",
                column: "course_id",
                principalTable: "Courses",
                principalColumn: "course_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Professors_Professorprof_id",
                table: "Subjects",
                column: "Professorprof_id",
                principalTable: "Professors",
                principalColumn: "prof_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Rooms_room_id",
                table: "Subjects",
                column: "room_id",
                principalTable: "Rooms",
                principalColumn: "room_id");
        }
    }
}
