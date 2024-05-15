using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class StudentCollection : ISchoolCollection<Student>
    {
        private readonly SchoolDbContext _dbContext;


        public StudentCollection(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
            {
                //new Student()
                //{
                //    StudentID = 101,
                //    FirstName = "Anna",
                //    LastName = "Andersson",
                //    Courses = new List<int>()
                //    {
                //        102
                //    }
                //},
                //new Student()
                //{
                //    StudentID = 102,
                //    FirstName = "Bert",
                //    LastName = "Beritsson",
                //    Courses = new List<int>()
                //    {
                //        102
                //    }
                //},
                //new Student()
                //{
                //    StudentID = 103,
                //    FirstName = "Cecilia",
                //    LastName = "Carm",
                //    Courses = new List<int>()
                //    {
                //        101
                //    }
                //},
                //new Student()
                //{
                //    StudentID = 104,
                //    FirstName = "Dani",
                //    LastName = "Denire",
                //    Courses = new List<int>()
                //    {
                //        101

                //    }
                //}
            };
        }
        public void Add(Student entity)
        {
            entity.StudentID = _dbContext.Students.Max(c => c.StudentID) + 1;
            _dbContext.Students.Add(entity);
        }

        public void Delete(int id)
        {
            var student = Find(id);
            _dbContext.Students.Remove(student);
        }

        public Student Find(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(c => c.StudentID == id);
            if (student != null)
            {
                Console.WriteLine($"\n{student.StudentID} exists in database");
            }
            else
            {
                Console.WriteLine($"\n{id} doesn't exist in database");
            }
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContext.Students;
        }

        public void Update(int id, Student entity)
        {
            var student = Find(id);
            student.FirstName = entity.FirstName;
            _dbContext.SaveChanges();
        }
    }
}
