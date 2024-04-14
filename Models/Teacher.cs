using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        //public static List<Teacher> GetTeachers()
        //{
        //    List<Teacher> teachers = new List<Teacher>()
        //    {


        //        new Teacher()
        //        {
        //            TeacherID = 101,
        //            TeacherName = "Anas",
        //            Subjects = new List<int>() //Måste finnas något smidigt sätt där man går igenom listan och söker teacherid
        //            {
        //                101,
        //                103,
        //                104
        //            }
        //    },
        //        new Teacher()
        //        {
        //            TeacherID = 102,
        //            TeacherName = "Reidar",
        //            Subjects = new List<int>()
        //            {
        //                101,
        //                102,
        //                104
        //            }
        //        },
        //        new Teacher()
        //        {
        //            TeacherID = 103,
        //            TeacherName = "Tobias",
        //            Subjects = new List<int>()
        //            {
        //                102,
        //                103,
        //                104
        //            }
        //        }

        //    };
        //    return teachers;
        //}

    //}
}
