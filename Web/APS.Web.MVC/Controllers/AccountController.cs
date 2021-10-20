using APS.CMS.Application.Publications.Queries.RegistrationUser;
using APS.Web.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace APS.Web.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AccountController> _logger;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Переход для пользователя на страницу регистрациии
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        ///  Метод для регистрации нового пользователя.
        /// </summary>
        /// <param name="registrationUserRequest"> Запроса на регистрацию пользователя.</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegistrationUserRequest registrationUserRequest, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(registrationUserRequest, cancellationToken);
            return View("LogIn");
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
