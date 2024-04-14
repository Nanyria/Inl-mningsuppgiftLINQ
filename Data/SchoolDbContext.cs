using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models;
using Microsoft.EntityFrameworkCore;


namespace InlämningsuppgiftLINQ.Data
{
    internal class SchoolDbContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = LUPIN;Intital Catalog = LINQSchoolDb;Integrated Security = True;");
        }
    }
}
