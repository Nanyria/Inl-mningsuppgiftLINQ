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
    internal class SubjectsTeacherMethods : ISchoolCollection<SubjectTeachersCollection>
    {
        private readonly SchoolDbContext _dbContext;

        public SubjectsTeacherMethods(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(SubjectTeachersCollection entity)
        {
            _dbContext.SubjectTeachersCollection.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(int subjectId, int teacherId)
        {
            var subT = Find(subjectId, teacherId);
            if (subT != null)
            {
                _dbContext.SubjectTeachersCollection.Remove(subT);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SubjectTeachersCollection Find(int subjectId, int teacherId)
        {
            return _dbContext.SubjectTeachersCollection.FirstOrDefault(c => c.SubjectID == subjectId && c.TeacherID == teacherId);
        }

        public SubjectTeachersCollection Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubjectTeachersCollection> GetAll()
        {
            return _dbContext.SubjectTeachersCollection.ToList();
        }

        public void Update(int subjectId, int teacherId, SubjectTeachersCollection entity)
        {
            var subT = Find(subjectId, teacherId);
            if (subT != null)
            {
                subT.SubjectID = entity.SubjectID;
                subT.TeacherID = entity.TeacherID;
                _dbContext.SaveChanges();
            }
        }

        public void Update(int id, SubjectTeachersCollection entity)
        {
            throw new NotImplementedException();
        }
    }
}

