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
    public class TeacherController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IConfiguration configuration;
        private string connectionString;
        DbContextOptionsBuilder<AppDbContext> optionsBuilder;


        public TeacherController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration config)
        {
            configuration = config;
            optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult TeacherLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TeacherLogin(TeacherLoginVM model)
        {
            if(ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("TeacherDashboard", "Teacher");
                }
                
                ModelState.AddModelError(string.Empty, "invalid login attempt");
            }

            // using (AppDbContext context = new AppDbContext(optionsBuilder.Options))
            // {
            //     ApplicationUser user = context.TeacherLogin.Single(x => x.UserName == model.Email);
            //     model.StudentCode = user.StudentCode;
            // }
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View("Views/Teacher/CreateAccount.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(CreateAccountVM model)
        {
            if(ModelState.IsValid)
            {
                model.StudentCode = GenerateStudentCode();
                var user = new ApplicationUser 
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    School = model.School,
                    UserName = model.Email, 
                    Email = model.Email, 
                    StudentCode = model.StudentCode,
                    UserType = "teacher",
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
            
            return View(model);
        }

        public IActionResult TeacherDashboard()
        {
            return View();
        }
        public IActionResult StudentStats()
        {
            return View();
        }

        public IActionResult ManageAccount()
        {
            return View();
        }

        public string GenerateStudentCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            return(finalString);
        }
    }
}