using ESCUELA.Data;
using ESCUELA.Dominio;
using ESCUELA.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Repositorio
{
    public class StudentRepository : IStudent
    {
        private ApplicationDbContext app;
        public StudentRepository(ApplicationDbContext app)
        {
            this.app = app;
        }

        public List<Students> ListOfStudent()
        {
            return app.Students.ToList();
        }
    }
}
