using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ELearningWebApp.Models
{
    public class ELearningModel
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(125)]
        public string CourseName { get; set; }
        [Required]
        [StringLength(125)]
        public string CourseCode { get; set; }
        [Required]
        [StringLength(125)]
        public string Duration { get; set; }
        [Required]
        [StringLength(125)]
        public string HoursPerDay { get; set; }
        [Required]
        [StringLength(125)]
        public string Prerequisites { get; set; }
        [Required]
        [StringLength(125)]
        public string CourseMaterial { get; set; }
        [Required]
        [Range(100, 200000)]
        public int Fee { get; set; }
    }
}
