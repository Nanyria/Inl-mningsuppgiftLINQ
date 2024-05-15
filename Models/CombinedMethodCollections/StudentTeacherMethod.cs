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
    internal class StudentTeacherMethod : ISchoolCollection<StudentTeachersCollection>
    {
        private readonly SchoolDbContext _dbContext;

        public StudentTeacherMethod(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(StudentTeachersCollection entity)
        {
            _dbContext.StudentTeachersCollections.Add(entity);
            _dbContext.SaveChanges();
        }
        public void Delete(int studentID, int teacherId)
        {
            var studentTeach = Find(studentID, teacherId);
            if (studentTeach != null)
            {
                _dbContext.StudentTeachersCollections.Remove(studentTeach);
                _dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public StudentTeachersCollection Find(int id)
        {
            throw new NotImplementedException();
        }
        public StudentTeachersCollection Find(int studentID, int teacherId)
        {
            return _dbContext.StudentTeachersCollections.FirstOrDefault(c => c.StudentID == studentID && c.TeacherID == teacherId);
        }
        public IEnumerable<StudentTeachersCollection> GetAll()
        {
            return _dbContext.StudentTeachersCollections.ToList();
        }
        public void Update(int studentID, int teacherId, StudentTeachersCollection entity)
        {
            var studentTeach = Find(studentID, teacherId);
            if (studentTeach != null)
            {
                studentTeach.StudentID = entity.StudentID;
                studentTeach.TeacherID = entity.TeacherID;
                _dbContext.SaveChanges();
            }
        }
        public void Update(int id, StudentTeachersCollection entity)
        {
            throw new NotImplementedException();
        }
    }
}
