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

    internal class CourseSubjectsCollection
    {
        [Key]
        public int CSubID { get; set; }
        public Subject Subject { get; set; }
        public int SubjectID { get; set; }

        public Course Course { get; set; }
        public int CourseID { get; set; }
    }
}
