using InlämningsuppgiftLINQ.Data;
using InlämningsuppgiftLINQ.Models.BaseModels;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using InlämningsuppgiftLINQ.Models.CombinedMethodCollections;
using InlämningsuppgiftLINQ.Models.MethodCollections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ
{
    internal static class Join
    {
        public static void JoinTeacher(SchoolDbContext dbContext)
        {
            SubjectCollection subjectCollection = new SubjectCollection(dbContext);
            TeacherCollection teacherCollection = new TeacherCollection(dbContext);



            ////---------------Hämta alla lärare som undervisar matte
            SubjectsTeacherMethods subTCollection = new SubjectsTeacherMethods(dbContext);


            var joinMathTeachers = (from subTC in subTCollection.GetAll()
                                    join subC in subjectCollection.GetAll()
                                    on subTC.SubjectID equals subC.SubjectID
                                    where subC.SubjectsName.Contains("Math")
                                    join teacher in teacherCollection.GetAll()
                                    on subTC.TeacherID equals teacher.TeacherID
                                    select new
                                    {
                                        TeacherName = teacher.TeacherName,
                                        subjectName = subC.SubjectsName
                                    }).ToList();

           

            //IEnumerable<Subject> subjectCollections = subjectCollection.GetAll();
            foreach (var s in joinMathTeachers)
            {
                Console.WriteLine($"Subject: {s.subjectName}\nTeachers: {s.TeacherName}");


            }


           
            


            //foreach (var s in subjectCollections)
            //{
            //    Console.WriteLine($"Subject: {s.SubjectsName}\nTeachers: {s.SubjectTeachers}");


            //}

        }
        public static void CheckName(SchoolDbContext dbContext)
        {
            CourseCollection courseCollection = new CourseCollection(dbContext);
            StudentCollection studentCollection = new StudentCollection(dbContext);
            SubjectCollection subjectCollection = new SubjectCollection(dbContext);
            //-------------Kolla om ämnen innehåller Programmering 1

            var hittanamn = subjectCollection.FindName("Programming 1");


        }
        public static void ChangeName(SchoolDbContext dbContext)
        {

            SubjectCollection subjectCollection = new SubjectCollection(dbContext);
            //-------------Kolla om ämnen innehåller Programmering 1

            //--------------Ändra från programming 2 till OOP

            var subject = subjectCollection.FindName("Programming 2");
            //var subject = subjectCollection.FindName("OOP");

            if (subject != null)
            {
                // Skapar nytt ämne med nya namnet
                var updatedSubject = new Subject { SubjectID = subject.SubjectID, SubjectsName = "OOP" };
                //var updatedSubject = new Subject { SubjectID = subject.SubjectID, SubjectsName = "Programming 2" };

                // Updatera nya namnet
                subjectCollection.Update(subject.SubjectID, updatedSubject);
            }
            else
            {
                // Om det inte finns
                Console.WriteLine("Subject with name Programming 2 not found.");

            }


        }
        public static void ChangeTeacherForStudent(SchoolDbContext dbContext)
        {
            CourseCollection courseCollection = new CourseCollection(dbContext);
            StudentCollection studentCollection = new StudentCollection(dbContext);
            SubjectCollection subjectCollection = new SubjectCollection(dbContext);
            TeacherCollection teacherCollection = new TeacherCollection(dbContext);

            var studentsTeachers = (from student in studentCollection.GetAll()
                                    join course in courseCollection.GetAll()
                                    on student.co equals subC.SubjectID
                                    where subC.SubjectsName.Contains("Math")
                                    join teacher in teacherCollection.GetAll()
                                    on subTC.TeacherID equals teacher.TeacherID
                                    select new
                                    {
                                        TeacherName = teacher.TeacherName,
                                        subjectName = subC.SubjectsName
                                    }).ToList();

            var changeStudentTeacher = 
        }

    }
}
