using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SightWordsProject.Models;

namespace SightWordsProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Login()
        {
            return View("Views/Student/StudentLogin.cshtml");
        }
        public IActionResult Dashboard()
        {
            return View("Views/Student/StudentDashboard.cshtml");
        }
        public IActionResult Stages()
        {
            return View();
        }

    }
}