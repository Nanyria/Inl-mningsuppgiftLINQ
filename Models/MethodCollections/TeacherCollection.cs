using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class TeacherCollection : ISchoolCollection<Teacher>
    {
        private readonly SchoolDbContext _dbContext;

        public TeacherCollection(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Teacher entity)
        {
            entity.TeacherID = _dbContext.Teachers.Max(c => c.TeacherID) + 1;
            _dbContext.Teachers.Add(entity);
        }

        public void Delete(int id)
        {
            var teacher = Find(id);
            _dbContext.Teachers.Remove(teacher);
        }

        public Teacher Find(int id)
        {
            var teacher = _dbContext.Teachers.FirstOrDefault(c => c.TeacherID == id);
            return teacher;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _dbContext.Teachers.ToList();
        }

        public void Update(int id, Teacher entity)
        {
            var teacher = Find(id);
            teacher.TeacherName = entity.TeacherName;
        }
    }
}
