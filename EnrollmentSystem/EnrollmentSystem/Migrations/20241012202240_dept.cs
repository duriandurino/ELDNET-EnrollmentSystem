using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class dept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Departmentdept_id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Departmentdept_id",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "dept_id",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dept_id",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "Departmentdept_id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Departmentdept_id",
                table: "Courses",
                column: "Departmentdept_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_Departmentdept_id",
                table: "Courses",
                column: "Departmentdept_id",
                principalTable: "Departments",
                principalColumn: "dept_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
