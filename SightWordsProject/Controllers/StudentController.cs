using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SightWordsProject.Models;
using SightWordsProject.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SightWordsProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;
        private string connectionString;
        DbContextOptionsBuilder<AppDbContext> optionsBuilder;
        public StudentController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration config)
        {
            configuration = config;
            optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
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
        public async Task<IActionResult> CreateAccount(CreateStudentAccountVM model)
        {
            using (AppDbContext context = new AppDbContext(optionsBuilder.Options))
            {
                bool code = context.TeacherLogin.Any(x => x.StudentCode == model.AccessCode);
                if(!code)
                {
                    ModelState.AddModelError("","Teacher's access code was not found");
                }
            }
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser 
                {
                    FirstName = model.ParentFirst,
                    LastName = model.ParentLast,
                    StudentCode = model.AccessCode,
                    StudentId = model.StudentId, 
                    UserName = model.Email,
                    Email = model.Email,
                    UserType = "student",
                };


                var result = await userManager.CreateAsync(user,model.Password);

                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("StudentDashboard", "Student");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            
            return View(model);
        }

    }
}