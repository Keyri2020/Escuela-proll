using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCUELA.Servicio;
using ESCUELA.Dominio;
using ESCUELA.Data;

namespace ESCUELA.Repositorio
{
    public class CourseRepositorio : ICourses
    {
        //implementar no es lo mismo que hacer herencia

        private ApplicationDbContext app;

        public CourseRepositorio(ApplicationDbContext app)
        {
            this.app = app;
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
            app.Add(c);
            app.SaveChanges();
        }

        public ICollection<Course> ListarCursos()
        {
            return app.Courses.ToList();
        }

        void ICourses.CourseRepositorio(ApplicationDbContext app)
        {
            throw new NotImplementedException();
        }

        //  El servicio solamente va a ser para decirle al repositorio cómo va a trabajar, y
        //el repositorio simple y sencillamente va a implementar lo que es esa interfaz y el mismo hara la conexión a la base de datos con la cual se va a trabajar

    }
}
