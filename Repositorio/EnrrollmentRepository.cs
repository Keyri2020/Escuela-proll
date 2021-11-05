using ESCUELA.Data;
using ESCUELA.Dominio;
using ESCUELA.Servicio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Repositorio
{
    public class EnrrollmentRepository : IRollments
    {
        private ApplicationDbContext db;
        public EnrrollmentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<Enrrollment> UnionTablas()
        {
            
            var union = db.Enrrollments.Include(e => e.Student).Include (c => c.Course).ToList();

            return union;
        }

    }
}