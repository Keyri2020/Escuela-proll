using ESCUELA.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Models
{
    public class EnrrollmentViewModel
    {
        [Display(Name = "Enrrollments")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]

        public int EnrrollmentId { get; set; }

        [Display(Name = "CourseId")]
        public int CourseId { get; set; }

        [Display(Name = "StudentId")]
        public int StudentId { get; set; }

        [Display(Name = "Grade")]
        public Grade? Grade { get; set; }

        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Display(Name = "Student")]
        public Students Student { get; set; }
    }
}
