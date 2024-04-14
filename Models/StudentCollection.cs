using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class StudentCollection : ISchoolCollection<Student>
    {
        List<Student> students;


        public StudentCollection() 
        {
            students = new List<Student>()
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
            entity.StudentID = students.Max(c => c.StudentID) + 1;
            students.Add(entity);
        }

        public void Delete(int id)
        {
            var student = Find(id);
            students.Remove(student);
        }

        public Student Find(int id)
        {
            var student = students.FirstOrDefault(c => c.StudentID == id);
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            return students;
        }

        public void Update(int id, Student entity)
        {
            var student = Find(id);
            student.FirstName = entity.FirstName;
        }
    }
}
