using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectsName { get; set; }
        public List<int> Teachers { get; set; } //List<Teacher>?

    }
}

