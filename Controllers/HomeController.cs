using ESCUELA.Dominio;
using ESCUELA.Models;
using ESCUELA.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICourses icourses;

        public HomeController(ILogger<HomeController> logger, ICourses icourses)
        {
            this.icourses = icourses;
            _logger = logger;
        }

        public IActionResult Index(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", viewModel);
            }
            else
            {
                Course course = new Course();
                
                course.Title = viewModel.Title;
                course.Credits = viewModel.Credits;
                icourses.Insertar(course);


                return View("Index");
            }
        }

        //public IActionResult Insert

        public IActionResult GetAll()
        {
            var DandoFormatoJson = icourses.ListarCursos();
            return Json(new { data = DandoFormatoJson });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
