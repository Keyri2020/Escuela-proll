using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Dominio
{
    //Nos va a servir para que podamos utilizar justamente datos que nosotros esperamos en la base de datos
    public enum Grade //este va a contener la coleccion
    {
        A, B, C, D //tipos de datos que esperamos sean guardados en la base de datos
    }

    public class Enrrollment
    {
        [Key] // atributo para que reconozca la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int EnrrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public Grade? Grade { get; set; }     //atraves de este signo "?" vamos a especificar una decision, esas decisiones quieren decir que van a esperar algo que viene por partes desde el front-end 

        public Course Course { get; set; }

        public Students Student { get; set; }

    }
    // Migraciones: no significa que se traslada de una base de datos a otra, sino que significan que va a generar una base de datos desde entity framework por ejemplo y que esa base de datos se va a migrar
    // hacia un servidor de base de datos.
    // para agregar una migracion se hace atraves del "Add-Migration", van a tener el mismo nombre con el cual se crearon. Para eliminarla se usa Remove-Migration

}
