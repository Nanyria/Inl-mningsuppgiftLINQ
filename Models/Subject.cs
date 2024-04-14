using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsuppgiftLINQ.Models
{
    internal class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        [Required]
        [StringLength(50)]
        public string SubjectsName { get; set; }
        public ICollection<Teacher> Teachers { get; set; } //List<Teacher>?

    }
}

