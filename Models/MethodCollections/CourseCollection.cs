using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class CourseCollection : ISchoolCollection<Course>
    {
        private readonly SchoolDbContext _dbContext;

        public CourseCollection(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
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
            entity.CourseID = _dbContext.Courses.Max(c => c.CourseID) + 1;
            _dbContext.Courses.Add(entity);
        }

        public void Delete(int id)
        {
            var course = Find(id);
            _dbContext.Courses.Remove(course);
        }

        public Course Find(int id)
        {
            var course = _dbContext.Courses.FirstOrDefault(c => c.CourseID == id);
            return course;
        }

        public IEnumerable<Course> GetAll()
        {
            return _dbContext.Courses;
        }

        public void Update(int id, Course entity)
        {
            var course = Find(id);
            course.Name = entity.Name;
            _dbContext.SaveChanges();
        }
    }
}
