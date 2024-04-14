using InlämningsuppgiftLINQ.Models;

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

        }
    }
}
