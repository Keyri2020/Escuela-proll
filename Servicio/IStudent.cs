using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCUELA.Dominio;

namespace ESCUELA.Servicio
{
    public interface IStudent
    {
        List<Students> ListOfStudent();
    }
}
