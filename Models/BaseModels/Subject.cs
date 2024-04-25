using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.CollectionTables;

namespace InlämningsuppgiftLINQ.Models.BaseModels
{
    internal class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubjectsName { get; set; }
        public ICollection<CourseStudentsCollection> CourseStudents { get; set; }
        public ICollection<SubjectTeachersCollection> SubjectTeachers { get; set; }


    }
}

