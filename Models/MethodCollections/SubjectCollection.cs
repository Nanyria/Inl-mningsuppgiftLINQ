using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using Microsoft.EntityFrameworkCore;

namespace InlämningsuppgiftLINQ.Models.MethodCollections
{
    internal class SubjectCollection : ISchoolCollection<Subject>
    {
        private readonly SchoolDbContext _dbContext;
        public SubjectCollection(SchoolDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Subject entity)
        {
            entity.SubjectID = _dbContext.Subjects.Max(c => c.SubjectID) + 1;
            _dbContext.Subjects.Add(entity);
        }

        public void Delete(int id)
        {
            var subject = Find(id);
            _dbContext.Subjects.Remove(subject);
        }

        public Subject Find(int id)
        {
            var subject = _dbContext.Subjects.FirstOrDefault(c => c.SubjectID == id);
            return subject;
        }

        public Subject FindName(string name)
        {
            var subject = _dbContext.Subjects.FirstOrDefault(c => c.SubjectsName == name);
            if (subject != null)
            {
                Console.WriteLine($"\n{subject.SubjectsName} exists in database");
            }
            else
            {
                Console.WriteLine($"\n{name} doesn't exist in database");
            }
            return subject;
        }

        public IEnumerable<Subject> GetAll()
        {
            return _dbContext.Subjects.ToList();
        }

        public void Update(int id, Subject entity)
        {
            var subject = Find(id);
            subject.SubjectsName = entity.SubjectsName;

            Console.WriteLine($"Changed name of subject to {entity.SubjectsName}");
            _dbContext.SaveChanges();
        }
        public void UpdateFromName(string name, Subject entity)
        {
            var subject = FindName(name);
            subject.SubjectsName = entity.SubjectsName;

            Console.WriteLine($"Changed name of subject to {entity.SubjectsName}");
            _dbContext.SaveChanges();
        }
    }
}
