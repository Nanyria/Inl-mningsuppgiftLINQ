using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using InlämningsuppgiftLINQ.Models.MethodCollections;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace InlämningsuppgiftLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubjectCollection subjectCollection = new SubjectCollection();
            StudentCollection studentCollection = new StudentCollection();
            TeacherCollection teacherCollection = new TeacherCollection();
            CourseCollection courseCollection = new CourseCollection();
            //Hämta alla lärare som undervisar matte
            var joinForMathTeachers = subjectCollection.GetAll()
                .Where(s => s.SubjectsName.Contains("Math"))
                .SelectMany
                (
                sub => sub.SubjectTeachers.Select(
                    teacherID => new
                    {
                        SubjectName = sub.SubjectsName,
                        TeacherID = teacherID,
                    })
                .Join(teacherCollection.GetAll(),
                ts => ts.TeacherID,
                teacher => teacher.TeacherID,
                (ts, teacher) => new
                {
                    Subject = ts.SubjectName,
                    Teacher = teacher
                })
                .Select(s => new
                {
                    subName = s.Subject,
                    teach = s.Teacher.TeacherName
                })
                .ToList());


            //.Where(s => s.Name
            //.Contains("Math"))
            //.ToList();
            foreach (var subject in joinForMathTeachers)
            {
                Console.WriteLine($"Subject: {subject.subName}\nTeachers: {subject.teach}");


            }
            ----------------------------------------------------------------------------------------------//


        }
    }
}
