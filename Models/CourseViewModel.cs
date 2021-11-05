using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Models
{
    public class CourseViewModel
    {

        [Display(Name = "Courses")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]

        public string Title { get; set; }

        [Display(Name = "Credits")]
        [Range(0, int.MaxValue, ErrorMessage = "Credito no válido.")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]

        public int Credits { get; set; }
    }
}
