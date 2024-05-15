using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsuppgiftLINQ.Migrations
{
    public partial class Csub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseSubjectsCollections",
                columns: table => new
                {
                    CSubID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubjectsCollections", x => x.CSubID);
                    table.ForeignKey(
                        name: "FK_CourseSubjectsCollections_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSubjectsCollections_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "SubjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubjectsCollections_CourseID",
                table: "CourseSubjectsCollections",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubjectsCollections_SubjectID",
                table: "CourseSubjectsCollections",
                column: "SubjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSubjectsCollections");
        }
    }
}
