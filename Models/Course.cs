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
        public List<int> Subjects { get; set; } //List<Teacher>?

    }
}
