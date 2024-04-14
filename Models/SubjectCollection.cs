using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class SubjectCollection : ISchoolCollection<Subject>
    {
        List<Subject> subjects;
        public SubjectCollection()
        {
            subjects = new List<Subject>()
            {
                new Subject()
                {
                    SubjectID = 101,
                    SubjectsName = "Math 1",
                    Teachers = new List<int>()
                    {
                        //"Anas",
                        101,
                        //"Reidar"
                        102
                    }
                },
                new Subject()
                {
                    SubjectID = 102,
                    SubjectsName = "Math 2",
                    Teachers = new List<int>()
                    {
                        //"Reidar",
                        102,
                        //"Tobias"
                        103
                    }
                },
                new Subject()
                {
                    SubjectID = 103,
                    SubjectsName = "Programming 1",
                    Teachers = new List<int>()
                    {
                        //"Anas",
                        101,
                        //"Tobias"
                        103
                    }
                },
                new Subject()
                {
                    SubjectID = 104,
                    SubjectsName = "Programming 2",
                    Teachers = new List<int>()
                    {
                        //"Anas",
                        101,
                        //"Reidar",
                        102,
                        //"Tobias"
                        103
                    }
                }
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
