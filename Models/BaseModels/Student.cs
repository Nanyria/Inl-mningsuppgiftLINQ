using InlämningsuppgiftLINQ.Models.CollectionTables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models.BaseModels
{
    internal class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public Teacher Teacher { get; set; }
        public int? TeacherID { get; set; }

        public Course Course { get; set; }
        public int? courseID {  get; set; }

        public ICollection<StudentTeachersCollection> StudentTeachers { get; set; }
    }
}
