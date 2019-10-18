using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SightWordsProject.Models;
using SightWordsProject.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace SightWordsProject.Controllers
{
    public class TeacherController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public TeacherController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
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