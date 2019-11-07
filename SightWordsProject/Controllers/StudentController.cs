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

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult StudentLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> StudentLogin(StudentLoginVM model)
        {
            if(ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.StudentId, model.Password, model.RememberMe, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("StudentDashboard", "Student");
                }
                
                ModelState.AddModelError(string.Empty, "invalid login attempt");
            }
            return View(model);
        }
        public IActionResult StudentDashboard()
        {
            return View();
        }
        public IActionResult Stages()
        {
            return View("Views/Student/StudentStages.cshtml");
        }
        public IActionResult StageGame()
        {
            return View("Views/Student/Game/Stage1.cshtml");
        }
        public IActionResult StageGame2()
        {
            return View("Views/Student/Game/Stage2.cshtml");
        }
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View("Views/Student/CreateAccount.cshtml");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {

            return View("Views/Student/ForgotPassword.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(CreateStudentAccountVM model)
        {
            using (AppDbContext context = new AppDbContext(optionsBuilder.Options))
            {
                bool code = context.TeacherLogin.Any(x => x.StudentCode == model.AccessCode && x.UserType == "teacher");
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
                    UserName = model.StudentId,
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