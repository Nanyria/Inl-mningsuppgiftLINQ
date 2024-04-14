using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  List<int> Courses { get; set; }
        //public List<Subject> Subject { get; set; } ?

        //public static List<Student> GetAllStudents()
        //{
        //    List<Student> students = new List<Student>()
        //    {
        //        new Student()
        //        {
        //            StudentID = 101,
        //            FirstName = "Anna",
        //            LastName = "Andersson",
        //            Courses = new List<string>()
        //            {
        //                "SUT21"
        //            }
        //        },
        //        new Student()
        //        {
        //            StudentID = 102,
        //            FirstName = "Bert",
        //            LastName = "Beritsson",
        //            Courses = new List<string>()
        //            {
        //                "SUT21"
        //            }
        //        },
        //        new Student()
        //        {
        //            StudentID = 103,
        //            FirstName = "Cecilia",
        //            LastName = "Carm",
        //            Courses = new List<string>()
        //            {
        //                "SUT22"
        //            }
        //        },
        //        new Student()
        //        {
        //            StudentID = 104,
        //            FirstName = "Dani",
        //            LastName = "Denire",
        //            Courses = new List<string>()
        //            {
        //                "SUT22"

        //            }
        //        }
        //    };
        //    return students;
        //}
    }
}
