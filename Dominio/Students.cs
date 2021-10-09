using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //ayuda a generar las tablas, las cuales se pudan hacer autoincrementable
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Dominio
{
    public class Students
    {
        [Key] //definir la llave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //identidad autoincrementable

        public int StudentsId { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrrollmentsDate { get; set; }

        public ICollection<Enrrollment> Enrrollments { get; set; }
    }
}
