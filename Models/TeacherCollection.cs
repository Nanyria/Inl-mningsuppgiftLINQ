using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class TeacherCollection : ISchoolCollection<Teacher>
    {
        List<Teacher> teachers;

        public TeacherCollection()
        {
            teachers = new List<Teacher>()
            {
                //new Teacher()
                //{
                //    TeacherID = 101,
                //    TeacherName = "Anas",
                //    Subjects = new List<int>() //Måste finnas något smidigt sätt där man går igenom listan och söker teacherid
                //    {
                //        101,
                //        103,
                //        104
                //    }
                //},
                //new Teacher()
                //{
                //    TeacherID = 102,
                //    TeacherName = "Reidar",
                //    Subjects = new List<int>()
                //    {
                //        101,
                //        102,
                //        104
                //    }
                //},
                //new Teacher()
                //{
                //    TeacherID = 103,
                //    TeacherName = "Tobias",
                //    Subjects = new List<int>()
                //    {
                //        102,
                //        103,
                //        104
                //    }
                //}
            };
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
