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
    internal class CourseSubjectsMethods : ISchoolCollection<CourseSubjectsCollection>
    {
        private readonly SchoolDbContext _dbContext;

        public CourseSubjectsMethods(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(CourseSubjectsCollection entity)
        {
            _dbContext.CourseSubjectsCollections.Add(entity);
            _dbContext.SaveChanges();
        }


        public void Delete(int subjectID, int courseID)
        {
            var studentCourse = Find(subjectID, courseID);
            if (studentCourse != null)
            {
                _dbContext.CourseSubjectsCollections.Remove(studentCourse);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CourseSubjectsCollection Find(int subjectID, int courseID)
        {
            return _dbContext.CourseSubjectsCollections.FirstOrDefault(c => c.SubjectID == subjectID && c.CourseID == courseID);
        }

        public CourseSubjectsCollection Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CourseSubjectsCollection> GetAll()
        {
            return _dbContext.CourseSubjectsCollections.ToList();
        }

        public void Update(int subjectID, int courseID, CourseSubjectsCollection entity)
        {
            var studentCourse = Find(subjectID, courseID);
            if (studentCourse != null)
            {
                studentCourse.SubjectID = entity.SubjectID;
                studentCourse.CourseID = entity.CourseID;
                _dbContext.SaveChanges();
            }
        }

        public void Update(int id, CourseSubjectsCollection entity)
        {
            throw new NotImplementedException();
        }



    }
}
