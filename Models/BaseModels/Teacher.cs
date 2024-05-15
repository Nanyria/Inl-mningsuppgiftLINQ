using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsuppgiftLINQ.Models.CollectionTables;
using InlämningsuppgiftLINQ.Models.MethodCollections;

namespace InlämningsuppgiftLINQ.Models.BaseModels
{
    internal class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherName { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<SubjectTeachersCollection> TeacherSubjects { get; set; }
        public ICollection<StudentTeachersCollection> StudentTeachers { get; set; }
    }
}
