using ESCUELA.Dominio;
using ESCUELA.Models;
using ESCUELA.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private IRollments irollments;
        private IStudent istudent;
        public HomeController(ILogger<HomeController> logger, ICourses icourses, IRollments irollments, IStudent istudent)
        {
            this.icourses = icourses;
            this.irollments = irollments;
            this.istudent = istudent;
            _logger = logger;
        }

        public IActionResult MostrarDatos()
        {
            var listado = irollments.UnionTablas();
            _ = listado;

            return View(listado);
        }
        public IActionResult GetAllForJoinJsonLinq()
        {
            //llamar sobre que se hara la consulta(sobre la union de las tablas) no a base de datos, sino a arreglos
            var listado = irollments.UnionTablas();

            var CombinacionDeArreglos = (from union in listado
                                         select new
                                         {
                                             union.Course.Title,
                                             union.Student.LastName,
                                             union.Student.FirstMidName,
                                             union.Grade
                                         }).ToList();

            return Json(new { CombinacionDeArreglos });
        }
        //ajax para tener una sincronia con la aplicacion web y la parte del back-end

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult ComboBox()
        {
            var informationOftheComboBox = icourses.ListarCursos();
            var informationOftheComboBoxStudents = istudent.ListOfStudent();

            List<SelectListItem> ListCourse = new List<SelectListItem>();
            List<SelectListItem> ListStudents = new List<SelectListItem>();

            foreach (var iterarinformation in informationOftheComboBox){
                ListCourse.Add(new SelectListItem
                {
                    Text = iterarinformation.Title,
                    Value = Convert.ToString(iterarinformation.CouserId)

                });
                ViewBag.estadoListCourse = ListCourse;
            }

            foreach (var iterarinformation in informationOftheComboBoxStudents)
            {
                ListStudents.Add(new SelectListItem
                {
                    Text = iterarinformation.FirstMidName,
                    Value = Convert.ToString(iterarinformation.StudentsId)

                });
                ViewBag.estadoListStudent = ListStudents;
            }

            return View();
        }

        public IActionResult getInformationComboBox(Enrrollment e)
        {
            _ = e;
            return View("ComboBox");
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