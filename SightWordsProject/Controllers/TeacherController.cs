using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SightWordsProject.Models;

namespace SightWordsProject.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Login()
        {
            return View("Views/Teacher/TeacherLogin.cshtml");
        }
    }
}