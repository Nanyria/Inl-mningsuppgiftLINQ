using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    public partial class singlecourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Students",
                newName: "courseID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_CourseID",
                table: "Students",
                newName: "IX_Students_courseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_courseID",
                table: "Students",
                column: "courseID",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_courseID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "courseID",
                table: "Students",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_courseID",
                table: "Students",
                newName: "IX_Students_CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }
    }
}
