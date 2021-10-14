using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCUELA.Data;
using ESCUELA.Dominio;

namespace ESCUELA.Servicio
{
    public interface ICourses
    {
        //interfaces que otras clases tienen que implementar, es decir que tiene que tener todos los metodos que esta lleva

        void Insertar(Course c);

        void Delete(Course c);

        void Buscar(Course c);

        ICollection<Course> ListarCursos();

        void CourseRepositorio(ApplicationDbContext app);
    }
}
