
using APS.Dbs.Domain.Entities.Identity;
using APS.UIS.LoginUser;
using APS.UIS.RegistrationUser;
using APS.Web.MVC.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
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
        private readonly SignInManager<User> _signInManager;

        public AccountController(IMediator mediator, SignInManager<User> signInManager)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
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
            try
            {
                var response = await _mediator.Send(registrationUserRequest, cancellationToken);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Что-то пошло не так!: {ex}");
            }
            return View("LogIn");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("LogIn");
        }

        /// <summary>
        /// Метод для аунтетификации пользователя.
        /// </summary>
        /// <param name="loginUserRequest">Модель авторизации</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginUser(LoginUserRequest loginUserRequest, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _mediator.Send(loginUserRequest, cancellationToken);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine($"{ex.Message}");
                Redirect("LogIn");
            }
            return RedirectToAction("Index", "Home");
        }


        /// <summary>
        /// Метод для выхода из аккаунта.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
