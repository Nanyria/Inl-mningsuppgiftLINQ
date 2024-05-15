using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    public partial class primary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "primaryTeacherStudents",
                columns: table => new
                {
                    PTSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_primaryTeacherStudents", x => x.PTSID);
                    table.ForeignKey(
                        name: "FK_primaryTeacherStudents_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_primaryTeacherStudents_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "TeacherID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_primaryTeacherStudents_StudentID",
                table: "primaryTeacherStudents",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_primaryTeacherStudents_TeacherID",
                table: "primaryTeacherStudents",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "primaryTeacherStudents");
        }
    }
}
