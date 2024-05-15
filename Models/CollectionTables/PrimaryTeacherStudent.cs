using InlämningsuppgiftLINQ.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models.CollectionTables
{
    internal class PrimaryTeacherStudent
    {
        [Key]
        public int PTSID { get; set; }
        public Student Student { get; set; }
        public int StudentID { get; set; }

        public Teacher Teacher { get; set; }
        public int TeacherID { get; set; }
    }
}
