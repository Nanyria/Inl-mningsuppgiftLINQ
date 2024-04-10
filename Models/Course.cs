using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public List<string> Subjects { get; set; } //List<Teacher>?

        public static List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>()
            {

                new Course()
                {
                    CourseID = 101,
                    Name = "SUT22",
                    Subjects = new List<string>()
                    {
                        "Math 1",
                        "Programming 1"
                    }
                },
                new Course()
                {
                    CourseID = 102,
                    Name = "SUT21",
                    Subjects = new List<string>()
                    {
                        "Math 2",
                        "Programming 2"
                    }
                }
            };
            return courses;

        }
    }
}
