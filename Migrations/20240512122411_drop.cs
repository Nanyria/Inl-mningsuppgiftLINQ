using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    public partial class drop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherID",
                table: "Students",
                column: "TeacherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }
    }
}
