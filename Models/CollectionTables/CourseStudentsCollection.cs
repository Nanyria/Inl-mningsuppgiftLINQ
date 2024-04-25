using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace InlämningsuppgiftLINQ.Models.CollectionTables
{
    
    internal class CourseStudentsCollection
    {
        [Key]
        public int CStuID { get; set; }
        public Course Course { get; set; }
        public int CourseID { get; set; }

        public Student Student { get; set; }
        public int StudentID { get; set; }
    }
}
