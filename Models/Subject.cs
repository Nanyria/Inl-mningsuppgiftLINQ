using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public List<string> Teachers { get; set; } //List<Teacher>?

        public static List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>()
            {
                new Subject()
                {
                    SubjectID = 101,
                    Name = "Math 1",
                    Teachers = new List<string>()
                    {
                        "Anas",
                        "Reidar"
                    }
                },
                new Subject()
                {
                    SubjectID = 102,
                    Name = "Math 2",
                    Teachers = new List<string>()
                    {
                        "Reidar",
                        "Tobias"
                    }
                },
                new Subject()
                {
                    SubjectID = 103,
                    Name = "Programming 1",
                    Teachers = new List<string>()
                    {
                        "Anas",
                        "Tobias"
                    }
                },
                new Subject()
                {
                    SubjectID = 104,
                    Name = "Programming 2",
                    Teachers = new List<string>()
                    {
                        "Anas",
                        "Reidar",
                        "Tobias"
                    }
                }
            };
            return subjects;

        }
    }
}
}
