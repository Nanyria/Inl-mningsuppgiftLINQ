using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.BaseModels;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class SubjectCollection : ISchoolCollection<Subject>
    {
        List<Subject> subjects;
        public SubjectCollection()
        {
            subjects = new List<Subject>()
            {
            };
        }

        public void Add(Subject entity)
        {
            entity.SubjectID = subjects.Max(c => c.SubjectID) + 1;
            subjects.Add(entity);
        }

        public void Delete(int id)
        {
            var subject = Find(id);
            subjects.Remove(subject);
        }

        public Subject Find(int id)
        {
            var subject = subjects.FirstOrDefault(c => c.SubjectID == id);
            return subject;
        }

        public IEnumerable<Subject> GetAll()
        {
            return subjects;
        }

        public void Update(int id, Subject entity)
        {
            var subject = Find(id);
            subject.SubjectsName = entity.SubjectsName;
        }
    }
}
