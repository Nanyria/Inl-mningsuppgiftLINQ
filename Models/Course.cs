using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Subject> Subjects { get; set; } //List<Teacher>?

    }
}
