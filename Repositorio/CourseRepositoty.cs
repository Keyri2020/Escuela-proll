using ESCUELA.Data;
using ESCUELA.Dominio;
using ESCUELA.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Repositorio
{
    public class CourseRepositoty : ICourses
    {
        private ApplicationDbContext app;

        public void CourseRepositorio(ApplicationDbContext app)
        {
            this.app=app;
        }

        public void Buscar(Course c)
        {
            app.Courses.Find(c);
        }



        public void Delete(Course c)
        {
            app.Courses.Remove(c);
        }

        public void Insertar(Course c)
        {
            app.Courses.Add(c);
            app.SaveChanges();
        }

        public ICollection<Course> ListarCursos()
        {
            return app.Courses.ToList();
        }
    }
}
