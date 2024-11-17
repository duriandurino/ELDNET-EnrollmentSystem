using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class moreentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "stud_id");

            migrationBuilder.AddColumn<string>(
                name: "stud_address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "stud_email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "stud_fname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "stud_lname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "stud_mname",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "stud_phone",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    prof_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prof_fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_mname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prof_speciality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.prof_id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    room_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    room_type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_id);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    sem_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sem_year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sem_start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sem_end = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.sem_id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    dept_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dept_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dept_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chair_Professorprof_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.dept_id);
                    table.ForeignKey(
                        name: "FK_Departments_Professors_Chair_Professorprof_id",
                        column: x => x.Chair_Professorprof_id,
                        principalTable: "Professors",
                        principalColumn: "prof_id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    course_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    course_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Departmentdept_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.course_id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_Departmentdept_id",
                        column: x => x.Departmentdept_id,
                        principalTable: "Departments",
                        principalColumn: "dept_id");
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    subj_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subj_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subj_section = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subj_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    subj_days = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    course_id = table.Column<int>(type: "int", nullable: true),
                    Professorprof_id = table.Column<int>(type: "int", nullable: true),
                    room_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.subj_id);
                    table.ForeignKey(
                        name: "FK_Subjects_Courses_course_id",
                        column: x => x.course_id,
                        principalTable: "Courses",
                        principalColumn: "course_id");
                    table.ForeignKey(
                        name: "FK_Subjects_Professors_Professorprof_id",
                        column: x => x.Professorprof_id,
                        principalTable: "Professors",
                        principalColumn: "prof_id");
                    table.ForeignKey(
                        name: "FK_Subjects_Rooms_room_id",
                        column: x => x.room_id,
                        principalTable: "Rooms",
                        principalColumn: "room_id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    user_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    role = table.Column<int>(type: "int", nullable: false),
                    course_id = table.Column<int>(type: "int", nullable: true),
                    section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_Users_Courses_course_id",
                        column: x => x.course_id,
                        principalTable: "Courses",
                        principalColumn: "course_id");
                });

            migrationBuilder.CreateTable(
                name: "Enrolls",
                columns: table => new
                {
                    enroll_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subjectsubj_id = table.Column<int>(type: "int", nullable: true),
                    Studentstud_id = table.Column<int>(type: "int", nullable: true),
                    enroll_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolls", x => x.enroll_id);
                    table.ForeignKey(
                        name: "FK_Enrolls_Students_Studentstud_id",
                        column: x => x.Studentstud_id,
                        principalTable: "Students",
                        principalColumn: "stud_id");
                    table.ForeignKey(
                        name: "FK_Enrolls_Subjects_Subjectsubj_id",
                        column: x => x.Subjectsubj_id,
                        principalTable: "Subjects",
                        principalColumn: "subj_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Departmentdept_id",
                table: "Courses",
                column: "Departmentdept_id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Chair_Professorprof_id",
                table: "Departments",
                column: "Chair_Professorprof_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Studentstud_id",
                table: "Enrolls",
                column: "Studentstud_id");

            migrationBuilder.CreateIndex(
                name: "IX_Enrolls_Subjectsubj_id",
                table: "Enrolls",
                column: "Subjectsubj_id");

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
                name: "IX_Users_course_id",
                table: "Users",
                column: "course_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrolls");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Professors");

            migrationBuilder.DropColumn(
                name: "stud_address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "stud_email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "stud_fname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "stud_lname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "stud_mname",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "stud_phone",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "stud_id",
                table: "Students",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Students",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Students",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");
        }
    }
}
