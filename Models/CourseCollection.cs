using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models;

namespace InlämningsuppgiftLINQ.Models
{
    internal class CourseCollection : ISchoolCollection<Course>
    {
        List<Course> courses;

        public CourseCollection()
        {
            courses = new List<Course>()
            {

                //new Course()
                //{
                //    CourseID = 101,
                //    Name = "SUT22",
                //    Subjects = new List<int>()
                //    {
                //        101,
                //        103
                //    }
                //},
                //new Course()
                //{
                //    CourseID = 102,
                //    Name = "SUT21",
                //    Subjects = new List<int>()
                //    {
                //        102,
                //        104
                //    }
                //}
            };

        }

        public void Add(Course entity)
        {
            entity.CourseID = courses.Max(c => c.CourseID) + 1;
            courses.Add(entity);
        }

        public void Delete(int id)
        {
            var course = Find(id);
            courses.Remove(course);
        }

        public Course Find(int id)
        {
            var course = courses.FirstOrDefault(c => c.CourseID == id);
            return course;
        }

        public IEnumerable<Course> GetAll()
        {
            return courses;
        }

        public void Update(int id, Course entity)
        {
            var course = Find(id);
            course.Name = entity.Name;
        }
    }
}
