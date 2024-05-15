using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models.CombinedMethodCollections
{
    internal class PrimatyTeacherMethods : ISchoolCollection<PrimaryTeacherStudent>
    {
        private readonly SchoolDbContext _dbContext;

        public PrimatyTeacherMethods(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(PrimaryTeacherStudent entity)
        {
            _dbContext.primaryTeacherStudents.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int studentID, int teacherID)
        {
            var primaryTeacher = Find(studentID, teacherID);
            if (primaryTeacher != null)
            {
                _dbContext.primaryTeacherStudents.Remove(primaryTeacher);
                _dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PrimaryTeacherStudent Find(int studentID, int teacherID)
        {
            return _dbContext.primaryTeacherStudents.FirstOrDefault(c => c.StudentID == studentID && c.TeacherID == teacherID);
        }
        public PrimaryTeacherStudent Find(int studentID)
        {
            return _dbContext.primaryTeacherStudents.FirstOrDefault(c => c.StudentID == studentID);
        }

        public IEnumerable<PrimaryTeacherStudent> GetAll()
        {
            return _dbContext.primaryTeacherStudents.ToList();
        }

        public void Update(int studentID, int teacherID, PrimaryTeacherStudent entity)
        {
            var studentCourse = Find(studentID, teacherID);
            if (studentCourse != null)
            {
                studentCourse.StudentID = entity.StudentID;
                studentCourse.TeacherID = entity.TeacherID;
                _dbContext.SaveChanges();
            }
        }
        public void Update(int id, PrimaryTeacherStudent entity)
        {
            throw new NotImplementedException();
        }
    }
}
