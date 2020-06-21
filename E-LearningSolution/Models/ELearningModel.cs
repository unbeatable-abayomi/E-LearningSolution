using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_LearningSolution.Models
{
    public class ELearningModel
    {
        public long Id { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Duration { get; set; }
        public string HoursPerDay { get; set; }
        public string Prerequisites { get; set; }
        public string CourseMaterial { get; set; }
        public int Fee { get; set; }

    }
}
