using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCUELA.Dominio;

namespace ESCUELA.Servicio
{
    public interface IStudent
    {
        void Insert(Students students);

        void Update(Students students);
        List<Students> ListOfStudent();
    }
}
