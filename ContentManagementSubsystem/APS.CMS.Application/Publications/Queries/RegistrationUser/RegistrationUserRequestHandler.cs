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

namespace APS.CMS.Application.Publications.Queries.RegistrationUser
{
    /// <summary>
    /// Данные запроса на регистрацию нового пользователя.
    /// </summary>
    public class RegistrationUserRequestHandler : IRequestHandler<RegistrationUserRequest, RegistrationUserResponse>
    {
        private readonly ApplicationContext _applicationContext;

        /// <summary>
        /// Конструктор обработчика запросов, на регистрацию нового пользователя.
        /// </summary>
        /// <param name="applicationContext">Контекст базы данных.</param>
        public RegistrationUserRequestHandler(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
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
            var registrationNewUser = new Person()
            {
                Id = Guid.NewGuid()
            };
            var user = new User
            {
                Person = registrationNewUser
            };

            //Добавление нового пользователя в базу данных.
            await _applicationContext.Users.AddAsync(user);

            //Асинхронно сохраняет все изменения в базу данных.
            await _applicationContext.SaveChangesAsync();

            //Возвращает экземпляр класса RegistrationUserResponse с Id новой записи о пользователе.
            return new RegistrationUserResponse
            {
                IdNewUser = registrationNewUser.Id
            };
        }
    }
}
