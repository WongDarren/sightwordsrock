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
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public IActionResult Login()
        {
            return View("Views/Student/StudentLogin.cshtml");
        }
        public IActionResult StudentDashboard()
        {
            return View();
        }
        public IActionResult Stages()
        {
            return View("Views/Student/StudentStages.cshtml");
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View("Views/Student/CreateAccount.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(CreateAccountVM model)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser 
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    School = model.School,
                    UserName = model.Email, 
                    Email = model.Email, 
                    StudentCode = model.StudentCode,
                };
                var result = await userManager.CreateAsync(user,model.Password);

                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("TeacherDashboard", "Teacher");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            
            return View("TeacherDashboard",model);
        }

    }
}