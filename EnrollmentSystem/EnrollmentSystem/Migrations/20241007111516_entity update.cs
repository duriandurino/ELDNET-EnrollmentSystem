using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnrollmentSystem.Migrations
{
    public partial class entityupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Courses_course_id",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_course_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "course_id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "section",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "course_id",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "section",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_course_id",
                table: "Users",
                column: "course_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Courses_course_id",
                table: "Users",
                column: "course_id",
                principalTable: "Courses",
                principalColumn: "course_id");
        }
    }
}
