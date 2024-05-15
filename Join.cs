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
using System.Xml.Linq;

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

        public static void StudentTeachers(SchoolDbContext dbContext, int studentId)
        {
            StudentCollection studentCollection = new StudentCollection(dbContext);
            PrimatyTeacherMethods primatyTeacherMethods = new PrimatyTeacherMethods(dbContext);
            TeacherCollection teacherCollection = new TeacherCollection(dbContext);
            SubjectsTeacherMethods SubjectTeacher = new SubjectsTeacherMethods(dbContext);
            SubjectCollection subjectCollection = new SubjectCollection(dbContext);
            CourseStudentMethods courseStudent = new CourseStudentMethods(dbContext);
            CourseSubjectsMethods coursesubj = new CourseSubjectsMethods(dbContext);

            var studentrecord = (
                from student in studentCollection.GetAll()
                where student.StudentID == studentId

                join courses in courseStudent.GetAll()
                on student.StudentID equals courses.StudentID

                join cSubjects in coursesubj.GetAll()
                on courses.CourseID equals cSubjects.CourseID

                join subject in subjectCollection.GetAll()
                on cSubjects.SubjectID equals subject.SubjectID
                where cSubjects.CourseID == courses.CourseID

                join studentTeacher in primatyTeacherMethods.GetAll()
                on student.StudentID equals studentTeacher.StudentID

                join teacher in teacherCollection.GetAll()
                on studentTeacher.TeacherID equals teacher.TeacherID

                //join teacherSubject in SubjectTeacher.GetAll()
                //on teacher.TeacherID equals teacherSubject.TeacherID


                select new
                {
                    studentName = ($"{student.FirstName} {student.LastName}"),
                    teacherName = teacher.TeacherName,
                    subjectsTaken = subject.SubjectsName
                });

            string currentStudentName = null;
            foreach (var record in studentrecord)
            {
                // Print student name only once
                if (record.studentName != currentStudentName)
                {
                    Console.WriteLine($"Student Name: {record.studentName}");
                    currentStudentName = record.studentName;
                    Console.WriteLine($"Primary Teacher: {record.teacherName}");
                }

                // Print teacher name and subject for each record

                Console.WriteLine($"Subjects: {record.subjectsTaken}");

            }
            Console.WriteLine("____________________________\n");

        }
        public static void ChangeTeacherForThisStudent(SchoolDbContext dbContext, int studentId)
        {

            // Proceed with updating the student record

            // Assuming you have a method to update the student record in your StudentCollection class
            StudentCollection studentCollection = new StudentCollection(dbContext);
            TeacherCollection teacherCollection = new TeacherCollection(dbContext);
            PrimatyTeacherMethods primatyTeacherMethods = new PrimatyTeacherMethods(dbContext);
            // Retrieve the student entity that needs to be updated
            var studentToUpdate = studentCollection.Find(studentId);
            if (studentToUpdate != null)
            {
                // Find the current teacher of the student
                var primaryTeacher = primatyTeacherMethods.Find(studentId);

                // Find the new teacher (Reidar)
                var Reidar = teacherCollection.GetAll().FirstOrDefault(t => t.TeacherName == "Reidar");
                var Anas = teacherCollection.GetAll().FirstOrDefault(t => t.TeacherName == "Anas");

                if (primaryTeacher != null && Reidar != null)
                {
                    if (primaryTeacher.TeacherID == Anas.TeacherID)
                    {
                        primaryTeacher.TeacherID = Reidar.TeacherID;
                        primatyTeacherMethods.Update(studentId, Reidar.TeacherID, primaryTeacher);

                        // Save changes to the database
                        dbContext.SaveChanges();

                        Console.WriteLine("Student's teacher updated successfully from Anas to Reidar.");
                    }
                    //if (primaryTeacher.TeacherID == Reidar.TeacherID)
                    //{
                    //    primaryTeacher.TeacherID = Anas.TeacherID;
                    //    primatyTeacherMethods.Update(studentId, Anas.TeacherID, primaryTeacher);

                    //     Save changes to the database
                    //    dbContext.SaveChanges();

                    //    Console.WriteLine("Student's teacher updated successfully from Reidar to Anas.");
                    //}

                }
                else
                {
                    Console.WriteLine("Failed to find current or new teacher.");
                }
            }
            else
            {
                Console.WriteLine("Student record not found.");
            }
            Console.WriteLine("____________________________\n");
        }

    }




    //private static bool TeachersTeachingSameSubject(SchoolDbContext dbContext, int studentId)
    //{
    //    StudentTeacherMethod studentTeachersMethod = new StudentTeacherMethod(dbContext);
    //    SubjectsTeacherMethods subjectsTeacherMethods = new SubjectsTeacherMethods(dbContext);
    //    TeacherCollection teacherCollection = new TeacherCollection(dbContext);
    //    SubjectCollection subjectCollection = new SubjectCollection(dbContext);

    //    var studentsTeachers = (
    //        from student in studentTeachersMethod.GetAll()
    //        where student.StudentID == studentId

    //        join subjectTeacher in subjectsTeacherMethods.GetAll() 
    //        on student.TeacherID equals subjectTeacher.TeacherID

    //        join subject in subjectCollection.GetAll()
    //        on subjectTeacher.SubjectID equals subject.SubjectID

    //        join teacher in teacherCollection.GetAll() 
    //        on subjectTeacher.TeacherID equals teacher.TeacherID
    //        where teacher.TeacherName == "Anas" || teacher.TeacherName == "Reidar"
    //        group subject.SubjectID by teacher.TeacherName into g
    //        where g.Count() == 2 // Both Anas and Reidar must teach at least one subject
    //        select new
    //        {
    //            TeacherName = g.Key,
    //            SubjectIDs = g.ToList()
    //        }
    //    ).ToList();

    //    var subjectsTaughtByAnas = studentsTeachers.FirstOrDefault(x => x.TeacherName == "Anas")?.SubjectIDs;
    //    var subjectsTaughtByReidar = studentsTeachers.FirstOrDefault(x => x.TeacherName == "Reidar")?.SubjectIDs;

    //    // Check if Anas and Reidar teach the same subjects for the specified student
    //    return subjectsTaughtByAnas != null && subjectsTaughtByReidar != null &&
    //           subjectsTaughtByAnas.SequenceEqual(subjectsTaughtByReidar);
    //}
}


