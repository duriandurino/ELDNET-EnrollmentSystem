using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class idk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentdept_id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses",
                column: "Departmentdept_id",
                principalTable: "Departments",
                principalColumn: "dept_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentdept_id",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses",
                column: "Departmentdept_id",
                principalTable: "Departments",
                principalColumn: "dept_id");
        }
    }
}
