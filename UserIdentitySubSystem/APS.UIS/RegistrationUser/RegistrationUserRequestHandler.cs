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
using System.Security.Claims;

namespace APS.UIS.RegistrationUser
{
    /// <summary>
    /// Данные запроса на регистрацию нового пользователя.
    /// </summary>
    public class RegistrationUserRequestHandler : IRequestHandler<RegistrationUserRequest, RegistrationUserResponse>
    {
        private readonly UserManager<User> _userManager;


        /// <summary>
        /// Конструктор обработчика запросов, на регистрацию нового пользователя.
        /// </summary>
        /// <param name="userManager"></param>
        public RegistrationUserRequestHandler(UserManager<User> userManager)
        {
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
                SecurityStamp = Guid.NewGuid().ToString()
            };
         
            // Метод для создания нового пользователя. 
            await _userManager.CreateAsync(user, request.Password);

            // Метод для добавления объекта Claim. 
            await _userManager.AddClaimAsync(
                user, 
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
            
            // Возвращает экземпляр класса RegistrationUserResponse с Id новой записи о пользователе.
            return new RegistrationUserResponse
            {
                IdUser = user.Id,
                Url = "https://localhost:44369/"
            };
        }
    }
}
