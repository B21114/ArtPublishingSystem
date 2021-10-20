using APS.Dbs.Domain.Entities.Identity;
using APS.DBS.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.CMS.Application.Publications.Queries.RegistrationUser
{
    /// <summary>
    /// Класс запроса на регистрацию нового пользователя.
    /// </summary>
    public class RegistrationUserRequest : IRequest<RegistrationUserResponse>
    {
        /// <summary>
        /// Почта пользователя.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Подтверждение пароля.
        /// </summary>
        public string ConfirmedPassword { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Отчество пользователя.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Дата рождения пользователя.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime ВirthDate { get; set; }
    }
}
