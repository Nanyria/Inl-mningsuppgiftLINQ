using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using Microsoft.EntityFrameworkCore;


namespace InlämningsuppgiftLINQ.Data
{
    internal class SchoolDbContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SubjectTeachersCollection> SubjectTeachersCollection { get; set; }
        public DbSet<CourseStudentsCollection> CourseStudentsCollections { get; set; }
        public DbSet<CourseSubjectsCollection> CourseSubjectsCollections { get; set; }
        public DbSet<StudentTeachersCollection> StudentTeachersCollections { get; set; }
        public DbSet<PrimaryTeacherStudent> primaryTeacherStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = LUPIN;Database = LINQSchoolDb2.0;Integrated Security = True;");
        }
    }
}
