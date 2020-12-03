using Midterm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm.Controllers
{
    public class StudentsController : Controller
    {

        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Students
        public ActionResult List()
        {
            var Students = _context.Students.ToList();
            return View(Students);
        }

        public ActionResult Create()
        {
            var course = _context.Courses.ToList();
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }
    }
}