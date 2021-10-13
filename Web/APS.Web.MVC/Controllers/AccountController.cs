using APS.Web.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APS.Web.MVC.Controllers
{
    public class AccountController : Controller
    {
       /* private readonly UserManager<User> _userManager;

        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Переход для пользователя на страницу регистрациии
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }*/

        /// <summary>
        /// Метод для регистрации нового пользователя.
        /// </summary>
        /// <param name="model">Пользователь</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterModel model)
        {/*
            if (modelstate.isvalid)
            {
                user user = new user { email = model.email, password = model.password };

                var result = await _usermanager.createasync(user, model.password);
                if (result.succeeded)
                {
                    await _signinmanager.signinasync(user, false);
                    return redirecttoaction("index","home");
                }
                else
                {
                    foreach(var error in result.errors)
                    {
                        modelstate.addmodelerror(string.empty, error.description);
                    }
                }
            }
            return view(model);*/
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        /// <summary>
        /// Метод для авторизации пользователя.
        /// </summary>
        /// <param name="loginModel">Модель авторизации</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginIn(LoginModel loginModel)
        {/*
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
                if (result.Succeeded)
                {
                    //Проверяем пренадлежит ои URL приложению
                    if (!string.IsNullOrEmpty(loginModel.ReturnUrl) && Url.IsLocalUrl(loginModel.ReturnUrl))
                    {
                        return Redirect(loginModel.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Не правильный логин и(или) пароль!");
                }
            }
            return View(loginModel);*/
            throw new NotImplementedException();
        } 
        

        /// <summary>
        /// Метод для выхода из аккаунта.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            /* await _signInManager.SignOutAsync();
             return RedirectToAction("Index", "Home");*/
            throw new NotImplementedException();
        }
    }
}
