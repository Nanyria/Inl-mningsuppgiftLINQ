using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace InlämningsuppgiftLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Hämta alla lärare som undervisar matte
            //var joinForMathTeachers = Subject.GetAllSubjects()
            //    .Where(s => s.SubjectsName.Contains("Math"))
            //    .SelectMany
            //    (
            //    sub => sub.Teachers.Select(
            //        teacherID => new
            //        {
            //            SubjectName = sub.SubjectsName,
            //            TeacherID = teacherID,
            //        })
            //    .Join(Teacher.GetTeachers(),
            //    ts => ts.TeacherID,
            //    teacher => teacher.TeacherID,
            //    (ts, teacher) => new 
            //    {
            //        Subject = ts.SubjectName, 
            //        Teacher = teacher 
            //    })
            //    .Select(s => new
            //    {
            //        subName = s.Subject,
            //        teach = s.Teacher.TeacherName
            //    })
            //    .ToList());


            //    //.Where(s => s.Name
            //    //.Contains("Math"))
            //    //.ToList();
            //foreach (var subject in joinForMathTeachers)
            //{
            //    Console.WriteLine($"Subject: {subject.subName}\nTeachers: {subject.teach}");


            //}
            //----------------------------------------------------------------------------------------------//

            using SchoolDbContext db = new SchoolDbContext();

            var subjects = new List<Subject>()
            {
                new Subject()
                {
                    SubjectID = 101,
                    SubjectsName = "Math 1",
                    Teachers = new List<Teacher>()
                    {
                        ////"Anas",
                        //TeacherID = 101,
                        ////"Reidar"
                        //102
                    }
                },
                new Subject()
                {
                    SubjectID = 102,
                    SubjectsName = "Math 2",
                Teachers = new List<Teacher>()
                {
                //    //"Reidar",
                //    102,
                //    //"Tobias"
                //    103
                }
                },
                new Subject()
                {
                    SubjectID = 103,
                    SubjectsName = "Programming 1",
                    Teachers = new List<Teacher>()
                    {
                    //    //"Anas",
                    //    101,
                    //    //"Tobias"
                    //    103
                    }
                },
                    new Subject()
                {
                    SubjectID = 104,
                    SubjectsName = "Programming 2",
                    Teachers = new List<Teacher>()
                    {
                    //    //"Anas",
                    //    101,
                    //    //"Reidar",
                    //    102,
                    //    //"Tobias"
                    //    103
                    }
                }
            };

            var teacher = new List<Teacher>()
            {
                new Teacher()
                {
                    TeacherID = 101,
                    TeacherName = "Anas",
                    Subjects = new List<Subject>()
                    {
                    //{
                    //    101,
                    //    103,
                    //    104
                    }
                },
                new Teacher()
                {
                    TeacherID = 102,
                    TeacherName = "Reidar",
                    Subjects = new List<Subject>()
                    {
                    //    101,
                    //    102,
                    //    104
                    }
                },
                new Teacher()
                {
                    TeacherID = 103,
                    TeacherName = "Tobias",
                    Subjects = new List<Subject>()
                    {
                    //    102,
                    //    103,
                    //    104
                    }
                }
            };

            foreach (var subject in subjects)
            {
                db.Subjects.Add(subject);
            }

            db.SaveChanges();


        }
    }
}
