using ESCUELA.Data;
using ESCUELA.Dominio;
using ESCUELA.Servicio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESCUELA.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext app;
        private IStudent istudent;

        public StudentController(IStudent istudent)
        {
            this.istudent = istudent;
            this.app = app;
        }

        public IActionResult ListStudents()
        {
            var ListOFStudents = istudent.ListOfStudent();
            return View(ListOFStudents);
        }

        [HttpPost]
        public IActionResult Index(Students model) //agregar
        {
            if (!ModelState.IsValid)
            {
                return View("ListStudents", model);

            }
            else
            {
                Students students = new Students();
                students.LastName = model.LastName;
                students.FirstMidName = model.FirstMidName;
                students.EnrrollmentsDate = model.EnrrollmentsDate;

                istudent.Insert(students);

            }
            return Redirect("ListStudents");
        }

        public IActionResult Update(Students model)
        {
            int update = model.StudentsId;
            Students upd = app.Students.Where(x => x.StudentsId == update).FirstOrDefault();
            upd.LastName = model.LastName;
            upd.FirstMidName = model.FirstMidName;
            upd.EnrrollmentsDate = model.EnrrollmentsDate;

            istudent.Update(upd);

            return View("ListStudents");
        }
    }
}
