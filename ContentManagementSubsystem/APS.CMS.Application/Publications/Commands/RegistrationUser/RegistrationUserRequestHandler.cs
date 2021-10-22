using APS.Dbs.Domain.Entities.Identity;
using APS.DBS.Domain;
using APS.DBS.Domain.Entities;
using APS.DBS.Domain.Entities.Identity;
using APS.Web.MVC.DataBaseContext;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace APS.CMS.Application.Publications.Queries.RegistrationUser
{
    /// <summary>
    /// Данные запроса на регистрацию нового пользователя.
    /// </summary>
    public class RegistrationUserRequestHandler : IRequestHandler<RegistrationUserRequest, RegistrationUserResponse>
    {
        private readonly ApplicationContext _applicationContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signManager;

        /// <summary>
        /// Конструктор обработчика запросов, на регистрацию нового пользователя.
        /// </summary>
        /// <param name="applicationContext">Контекст базы данных.</param>
        public RegistrationUserRequestHandler(ApplicationContext applicationContext, UserManager<User> userManager)
        {
            _applicationContext = applicationContext;
            _userManager = userManager;
        }

        /// <summary>
        /// Поток обрабатывает запрос, отвечает значением типа , RegistrationUserResponse
        /// запрашивает тип RegistrationUserRequest.
        /// </summary>
        /// <param name="request">Запрос, на создание нового пользователя</param>
        /// <param name="cancellationToken">Объект для наблюдения за ожиданием завершения задачи.</param>
        /// <returns></returns>
        public async Task<RegistrationUserResponse> Handle(RegistrationUserRequest request, CancellationToken cancellationToken)
        {
            var person = new Person()
            {
                Id = Guid.NewGuid(),
                Firstname = request.Firstname,
                Patronymic = request.Patronymic,
                Lastname = request.Lastname,
                ВirthDate = request.ВirthDate
            };
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Person = person,
                Email = request.Email,
            };
            await _userManager.CreateAsync(user, request.Password);

            //Возвращает экземпляр класса RegistrationUserResponse с Id новой записи о пользователе.
            return new RegistrationUserResponse
            {
                IdUser = user.Id,
                Url = "https://localhost:44369/"
            };
        }
    }
}
