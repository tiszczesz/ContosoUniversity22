using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity22.Data;
using Microsoft.AspNetCore.Mvc;
using ContosoUniversity22.Models;
using ContosoUniversity22.Models.SchoolViewModels;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity22.Controllers
{
    public class HomeController : Controller {
        private readonly SchoolContext _context;

        public HomeController(SchoolContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About() {
            IQueryable<EnrollmentDateGroup> data = from student in _context.Students
                group student by student.EnrollmentDate
                into dataGroup
                select new EnrollmentDateGroup() {
                    EnrollmentDate = dataGroup.Key,
                    StudentCount = dataGroup.Count()
                };
            return View(await data.AsNoTracking().ToListAsync());
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
