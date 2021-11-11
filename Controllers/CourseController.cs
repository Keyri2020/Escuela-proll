using ESCUELA.Dominio;
using ESCUELA.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Controllers
{
    public class CourseController : Controller
    {
        private ICourses icourses;
        public CourseController(ICourses icourses)
        {
            this.icourses = icourses;
        }

        public IActionResult Index(Course model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            else
            {
                Course course = new Course();

                course.Title = model.Title;
                course.Credits = model.Credits;
                icourses.Insertar(course);
                return View();
            }

        }

        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourses.ListarCursos();
            return Json(new { data = DandoFormatoJson });
        }
    }
}
