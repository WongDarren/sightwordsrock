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
        public IActionResult StudentLogin()
        {
            return View();
        }
        public IActionResult StudentStages()
        {
            return View();
        }
        [Route("/Home/Login"), HttpPost]
        public IActionResult GoToStudentLogin()
        {
            return View("Views/Student/StudentLogin.cshtml");
        }
    }
}