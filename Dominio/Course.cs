using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Dominio
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 

        public int CouserId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        // una conexion de datos que pertenezcan al enrrollement (nosotros la haremos, una conexion generica; es como un list)

        public ICollection<Enrrollment> Enrrollments { get; set; } //para indicar que existe una relacion entre el course y la clase enrrollment

    }
}
