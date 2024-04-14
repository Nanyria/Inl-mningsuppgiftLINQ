using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherName { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
