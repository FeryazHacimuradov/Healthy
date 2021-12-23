using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using One_HealthyV2._0.Data;
using One_HealthyV2._0.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace One_HealthyV2._0.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            List<Doctor> doctors = _context.Doctors.Include("Specialty").ToList();
            return View(doctors);
        }
    }
}
