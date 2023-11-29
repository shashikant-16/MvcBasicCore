using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MvcBasicCore.Models.Users;

namespace MvcBasicCore.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignIn() 
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View(loginViewModel);
        }

        [HttpPost]
        public Task<IActionResult> SignIn(LoginViewModel loginViewModel)
        {
            bool isValiduser = false;

            if (isValiduser)
            {
                return Task.FromResult<IActionResult>(RedirectToAction("Index", "Home"));
            }
            else
            {
                return Task.FromResult<IActionResult>(View(loginViewModel));
            }
        }

        public IActionResult ChangPassword(LoginViewModel loginViewModel)
        {
            //bool isValiduser = false;
            ChangePasswordViewModel cpvm= new ChangePasswordViewModel();
            return View(cpvm);


        }


           
        }
}
