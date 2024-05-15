using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;

namespace InlämningsuppgiftLINQ.Models.CombinedMethodCollections
{
    internal class CourseStudentMethods : ISchoolCollection<CourseStudentsCollection>
    {
        private readonly SchoolDbContext _dbContext;

        public CourseStudentMethods(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(CourseStudentsCollection entity)
        {
            _dbContext.CourseStudentsCollections.Add(entity);
            _dbContext.SaveChanges();
        }


        public void Delete(int studentID, int courseID)
        {
            var studentCourse = Find(studentID, courseID);
            if (studentCourse != null)
            {
                _dbContext.CourseStudentsCollections.Remove(studentCourse);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CourseStudentsCollection Find(int studentID, int courseID)
        {
            return _dbContext.CourseStudentsCollections.FirstOrDefault(c => c.StudentID == studentID && c.CourseID == courseID);
        }

        public CourseStudentsCollection Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseStudentsCollection> GetAll()
        {
            return _dbContext.CourseStudentsCollections.ToList();
        }

        public void Update(int studentID, int courseID, CourseStudentsCollection entity)
        {
            var studentCourse = Find(studentID, courseID);
            if (studentCourse != null)
            {
                studentCourse.StudentID = entity.StudentID;
                studentCourse.CourseID = entity.CourseID;
                _dbContext.SaveChanges();
            }
        }

        public void Update(int id, CourseStudentsCollection entity)
        {
            throw new NotImplementedException();
        }


    }
}
