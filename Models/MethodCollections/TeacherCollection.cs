using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.BaseModels;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class TeacherCollection : ISchoolCollection<Teacher>
    {
        private static List<Teacher> teachers;

        public TeacherCollection()
        {

        }
        public void Add(Teacher entity)
        {
            entity.TeacherID = teachers.Max(c => c.TeacherID) + 1;
            teachers.Add(entity);
        }

        public void Delete(int id)
        {
            var teacher = Find(id);
            teachers.Remove(teacher);
        }

        public Teacher Find(int id)
        {
            var teacher = teachers.FirstOrDefault(c => c.TeacherID == id);
            return teacher;
        }

        public IEnumerable<Teacher> GetAll()
        {
            return teachers;
        }

        public void Update(int id, Teacher entity)
        {
            var teacher = Find(id);
            teacher.TeacherName = entity.TeacherName;
        }
    }
}
