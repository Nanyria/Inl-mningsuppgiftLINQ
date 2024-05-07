using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    public partial class AddCoursestudentscoll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollection_Courses_CourseID",
                table: "CourseStudentsCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollection_Students_StudentID",
                table: "CourseStudentsCollection");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollection_Subjects_SubjectID",
                table: "CourseStudentsCollection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudentsCollection",
                table: "CourseStudentsCollection");

            migrationBuilder.RenameTable(
                name: "CourseStudentsCollection",
                newName: "CourseStudentsCollections");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollection_SubjectID",
                table: "CourseStudentsCollections",
                newName: "IX_CourseStudentsCollections_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollection_StudentID",
                table: "CourseStudentsCollections",
                newName: "IX_CourseStudentsCollections_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollection_CourseID",
                table: "CourseStudentsCollections",
                newName: "IX_CourseStudentsCollections_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudentsCollections",
                table: "CourseStudentsCollections",
                column: "CStuID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollections_Courses_CourseID",
                table: "CourseStudentsCollections",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollections_Students_StudentID",
                table: "CourseStudentsCollections",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollections_Subjects_SubjectID",
                table: "CourseStudentsCollections",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollections_Courses_CourseID",
                table: "CourseStudentsCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollections_Students_StudentID",
                table: "CourseStudentsCollections");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudentsCollections_Subjects_SubjectID",
                table: "CourseStudentsCollections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseStudentsCollections",
                table: "CourseStudentsCollections");

            migrationBuilder.RenameTable(
                name: "CourseStudentsCollections",
                newName: "CourseStudentsCollection");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollections_SubjectID",
                table: "CourseStudentsCollection",
                newName: "IX_CourseStudentsCollection_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollections_StudentID",
                table: "CourseStudentsCollection",
                newName: "IX_CourseStudentsCollection_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudentsCollections_CourseID",
                table: "CourseStudentsCollection",
                newName: "IX_CourseStudentsCollection_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseStudentsCollection",
                table: "CourseStudentsCollection",
                column: "CStuID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollection_Courses_CourseID",
                table: "CourseStudentsCollection",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollection_Students_StudentID",
                table: "CourseStudentsCollection",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudentsCollection_Subjects_SubjectID",
                table: "CourseStudentsCollection",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "SubjectID");
        }
    }
}
