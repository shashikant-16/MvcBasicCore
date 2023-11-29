using Microsoft.AspNetCore.Mvc;
//using Microsoft.CodeAnalysis.CSharp.Syntax;
using MvcBasicCore.UI.Models.Users;
using MvcBasicCore.BLL;
using MvcBasicCore.BLL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;


namespace MvcBasicCore.UI.Controllers
{
    public class UsersController : Controller
    {
        //private readonly UserManager<AppUser>

        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
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
            int userID = 0;
            bool isValiduser = _userService.isValidUser(loginViewModel.UserName,loginViewModel.Password,ref userID);

            if (isValiduser)
            {
                HttpContext.Session.SetInt32("UserID", userID);
                return Task.FromResult<IActionResult>(RedirectToAction("Index", "Home"));
            }
            else
            {
                return Task.FromResult<IActionResult>(View(loginViewModel));
            }
        }

        public IActionResult ChangPassword()
        {
            //bool isValiduser = false;
            ChangePasswordViewModel cpvm= new ChangePasswordViewModel();
            return View(cpvm);


        }

        [HttpPost]
        public IActionResult ChangPassword(ChangePasswordViewModel cpvm)
        {
            //bool isValiduser = false;
           
            return View(cpvm);


        }

        public IActionResult SignUp()
        {
       
            //bool isValiduser = false;

            UserRegistrationViewModel userRegistrationViewModel = new UserRegistrationViewModel();
            return View(userRegistrationViewModel);

        }

        [HttpPost]
        public IActionResult SignUp(UserRegistrationViewModel userRegistrationViewModel)
        {
            //bool isValiduser = false;
            
            return View(userRegistrationViewModel);
        }
    }
}
