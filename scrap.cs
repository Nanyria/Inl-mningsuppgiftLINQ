using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ
{
    internal class scrap
    {

        //using SchoolDbContext db = new SchoolDbContext();

        //var subjects = new List<Subject>()
        //{
        //        new Subject()
        //        {
        //            //SubjectID = 101,
        //            SubjectsName = "Math 1",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            //    ////"Anas",
        //            //    //TeacherID = 101,
        //            //    ////"Reidar"
        //            //    //102
        //            //},
        //            //CourseID = 101

        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 102,
        //            SubjectsName = "Math 2",
        //        //    Teachers = new List<Teacher>()
        //        //    {
        //        //    //    //"Reidar",
        //        //    //    102,
        //        //    //    //"Tobias"
        //        //    //    103
        //        //},
        //        //CourseID = 102
        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 103,
        //            SubjectsName = "Programming 1",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            ////    //"Anas",
        //            ////    101,
        //            ////    //"Tobias"
        //            ////    103
        //            //},
        //            //CourseID = 101
        //        },
        //        new Subject()
        //        {
        //            //SubjectID = 104,
        //            SubjectsName = "Programming 2",
        //            //Teachers = new List<Teacher>()
        //            //{
        //            ////    //"Anas",
        //            ////    101,
        //            ////    //"Reidar",
        //            ////    102,
        //            ////    //"Tobias"
        //            ////    103
        //            //},
        //            //CourseID = 102

        //        }
        //    };


        //var teachers = new List<Teacher>()
        //    {
        //        new Teacher()
        //        {
        //            //TeacherID = 101,
        //            TeacherName = "Anas",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    103,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Teacher()
        //        {
        //            //TeacherID = 102,
        //            TeacherName = "Reidar",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    102,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Teacher()
        //        {
        //            //TeacherID = 103,
        //            TeacherName = "Tobias",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //    103,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        }
        //    };
        //var subjectsUpdate = new List<Subject>()
        //    {
        //        new Subject()
        //        {
        //            SubjectID = 101,
        //            SubjectsName = "Math 1",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                102
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //        new Subject()
        //        {
        //            SubjectID = 102,
        //            SubjectsName = "Math 2",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                102,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //        new Subject()
        //        {
        //            SubjectID = 103,
        //            SubjectsName = "Programming 1",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        },
        //            new Subject()
        //        {
        //            SubjectID = 104,
        //            SubjectsName = "Programming 2",
        //            Teachers = teachers
        //            .Where(s => new List<int>
        //            {
        //                101,
        //                102,
        //                103
        //            }
        //            .Contains(s.TeacherID))
        //            .ToList()
        //        }
        //    };


        //var courses = new List<Course>()
        //    {

        //        new Course()
        //        {
        //            //CourseID = 101,
        //            Name = "SUT22",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //    103,
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        },
        //        new Course()
        //        {
        //            //CourseID = 102,
        //            Name = "SUT21",
        //            //Subjects = subjects
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //    104
        //            //}
        //            //.Contains(s.SubjectID))
        //            //.ToList()
        //        }
        //    };

        //var students = new List<Student>()
        //    {
        //        new Student()
        //        {
        //            //StudentID = 101,
        //            FirstName = "Anna",
        //            LastName = "Andersson",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 102,
        //            FirstName = "Bert",
        //            LastName = "Beritsson",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    102,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 103,
        //            FirstName = "Cecilia",
        //            LastName = "Carm",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        },
        //        new Student()
        //        {
        //            //StudentID = 104,
        //            FirstName = "Dani",
        //            LastName = "Denire",
        //            //Courses = courses
        //            //.Where(s => new List<int>
        //            //{
        //            //    101,
        //            //}
        //            //.Contains(s.CourseID))
        //            //.ToList()
        //        }
        //};

        ////CourseCollection trycourses = new CourseCollection();
        ////foreach (var c in trycourses.GetAll())
        ////{
        ////    Console.WriteLine($"CourseID: {c.CourseID}\n" +
        ////        $"Course name: {c.Name}\n" +
        ////        $"Subjects: {c.Subjects}\n" +
        ////        $"Students: {c.Students}\n");
        ////}

        //foreach (var subject in subjects)
        //{
        //    db.Subjects.Add(subject);
        //}

        //var cc = new List<CourseStudentsCollection>()
        //{
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 100,
        //        CourseID = 107,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 101,
        //        CourseID = 107,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 103,
        //        CourseID = 106,
        //    },
        //    new CourseStudentsCollection()
        //    {
        //        StudentID = 104,
        //        CourseID = 106,
        //    }
        //};

        //foreach (var cc in students)
        //{
        //    db.Students.Add();
        //}


        //db.SaveChanges();

    }
}
