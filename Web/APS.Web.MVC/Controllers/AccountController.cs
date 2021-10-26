using APS.CMS.Application.Publications.Queries.LoginUser;
using APS.CMS.Application.Publications.Queries.RegistrationUser;
using APS.Dbs.Domain.Entities.Identity;
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
        private readonly ILogger<AccountController> _logger;

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
            var response = await _mediator.Send(registrationUserRequest, cancellationToken);
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

            var response = await _mediator.Send(loginUserRequest, cancellationToken);
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
